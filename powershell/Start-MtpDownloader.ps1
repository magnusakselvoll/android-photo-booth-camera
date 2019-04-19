# Disclaimer
# Script is a modified version of this script (also mine):
# https://github.com/magnusakselvoll/flashair-photo-booth/blob/master/flashair-downloader/Start-FlashAirDownloader.ps1
#
# MTP code inspired by this blog:
# https://blog.daiyanyingyu.uk/2018/03/20/powershell-mtp/


param(
    [Parameter(Mandatory = $true)]
    [String]$MtpDeviceName,
    [Parameter(Mandatory = $true)]
    [String]$Source,
    [Parameter(Mandatory = $true)]
    [String]$Destination,
    [Parameter(Mandatory = $true)]
    [String]$PublishDirectory,
    [Parameter(Mandatory = $false)]
    [String]$PublishNamePattern = '{0}',
    [Parameter(Mandatory = $false)]
    [int]$PublishFilesPerSubfolder = 100,
    [Parameter(Mandatory = $false)]
    [String]$CompleteNamePattern = '{0}.complete',
    [Parameter(Mandatory = $false)]
    [String]$Filter = '*.jpg',
    [Parameter(Mandatory = $false)]
    [timespan]$RefreshInterval = (New-TimeSpan -Seconds 10),
    [Parameter(Mandatory = $false)]
    [timespan]$MaximumExecutionTime = (New-TimeSpan -Hours 24),
    [Parameter(Mandatory = $false)]
    [Switch]$DeleteFromSource = $false
)

$stopwatch = [system.diagnostics.stopwatch]::StartNew()
$secondsToSleep = $([int]($RefreshInterval.TotalSeconds))
$iteration = 0
$completedFiles = @{ }
[System.Collections.Queue]$filesToDelete = @()
$publishedFileCounter = 0
function Get-ShellProxy {
    if ( -not $global:ShellProxy) {
        $global:ShellProxy = new-object -com Shell.Application
    }
    $global:ShellProxy
}

function Get-MtpDevice {
    param($MtpDeviceName)
    $shell = Get-ShellProxy
    # 17 (0x11) = ssfDRIVES from the ShellSpecialFolderConstants (https://msdn.microsoft.com/en-us/library/windows/desktop/bb774096(v=vs.85).aspx)
    # => "My Computer" — the virtual folder that contains everything on the local computer: storage devices, printers, and Control Panel.
    # This folder can also contain mapped network drives.
    $shellItem = $shell.NameSpace(17).self
    $mtpDevice = $shellItem.GetFolder.items() | Where-Object { $_.name -eq $MtpDeviceName }
    return $mtpDevice
}

function Get-SubFolder {
    param($parent, [string]$path)
    $pathParts = @( $path.Split([system.io.path]::DirectorySeparatorChar) )
    $current = $parent
    foreach ($pathPart in $pathParts) {
        if ($pathPart) {
            $current = $current.GetFolder.items() | Where-Object { $_.Name -eq $pathPart }
        }
    }
    return $current
}

function Get-PublishFolder ([String] $baseFolder, [int] $filesPerSubfolder, [int] $fileNumber) {
    if (-not (Test-Path($baseFolder))) {
        New-Item -Path $baseFolder -ItemType Directory > $null
    }

    if ($filesPerSubfolder -le 0) {
        return $baseFolder
    }

    $folderNumber = [int] [Math]::Floor($fileNumber / $filesPerSubfolder)
    $folderName = "$($folderNumber * $filesPerSubfolder)-$((($folderNumber+1) * $filesPerSubfolder) - 1)"

    $publishFolder = "$baseFolder\$folderName"

    if (-not (Test-Path($publishFolder))) {
        New-Item -Path $publishFolder -ItemType Directory > $null
    }

    return $publishFolder
}

$mtpDevice = Get-MtpDevice -MtpDeviceName $MtpDeviceName
$mtpFolder = Get-SubFolder -parent $mtpDevice -path $Source
$shell = Get-ShellProxy
$destinationFolder = $shell.Namespace($Destination).self

while ($stopwatch.Elapsed -lt $MaximumExecutionTime) {
    $iteration++
    Write-Host "Starting iteration $iteration" -ForegroundColor Green

    $remoteFiles = $mtpFolder.GetFolder.items() | Where-Object {-not $_.IsFolder} # -and $_.Name -match $Filter}

    foreach ($remoteFile in $remoteFiles) {
        Write-Verbose "Evaluating file '$($remoteFile.Name)'"

        if ($completedFiles[$remoteFile.Name]) {
            Write-Verbose "File '$($remoteFile.Name)' already downloaded. Skipping."
            continue
        }

        $tokenFilePath = "$Destination\$CompleteNamePattern" -f $remoteFile.Name
        if (Test-Path($tokenFilePath)) {
            Write-Warning "File '$($remoteFile.Name)' already downloaded in previous session. Skipping."
            $completedFiles[$remoteFile.Name] = $true
            continue
        }

        Write-Host "Downloading file '$($remoteFile.Name)'"
        $copiedFile = Get-Item "$Destination\$($remoteFile.Name)"

        if ($DeleteFromSource)
        {
            $destinationFolder.GetFolder.MoveHere($remoteFile)
        }
        else
        {
            $destinationFolder.GetFolder.CopyHere($remoteFile)
        }
        
        $publishFolder = Get-PublishFolder $PublishDirectory $PublishFilesPerSubfolder $publishedFileCounter

        while (Test-Path("$publishFolder\$PublishNamePattern" -f "$publishedFileCounter$($copiedFile.Extension)")) {
            $publishedFileCounter++;
            $publishFolder = Get-PublishFolder $PublishDirectory $PublishFilesPerSubfolder $publishedFileCounter
        }

        $publishPath = "$publishFolder\$PublishNamePattern" -f "$publishedFileCounter$($copiedFile.Extension)"
        Write-Verbose "Moving file to $publishPath"

        $copiedFile | Move-Item -Destination $publishPath
        New-Item $tokenFilePath | Write-Verbose
        Write-Verbose "Created token file at $tokenFilePath"
        
        $completedFiles[$remoteFile.Name] = $true
        $publishedFileCounter++
    }


    Write-Host "Finished iteration $iteration. Sleeping for $secondsToSleep s." -ForegroundColor Green
    Write-Host ''
    Start-Sleep -Seconds $secondsToSleep
}