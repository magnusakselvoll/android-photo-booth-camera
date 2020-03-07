namespace Android_Photo_Booth
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label adbPathLabel;
            System.Windows.Forms.Label cameraAppLabel;
            System.Windows.Forms.Label focusKeepaliveIntervalLabel;
            System.Windows.Forms.Label pinCodeLabel;
            System.Windows.Forms.Label deviceImageFolderLabel;
            System.Windows.Forms.Label deleteAfterDownloadLabel;
            System.Windows.Forms.Label workingFolderLabel;
            System.Windows.Forms.Label fileSelectionRegexLabel;
            System.Windows.Forms.Label publishFolderLabel;
            System.Windows.Forms.Label publishFilenamePatternLabel;
            System.Windows.Forms.Label downloadImagesIntervalLabel;
            System.Windows.Forms.Label publishFilesPerFolderLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._adbBrowseButton = new System.Windows.Forms.Button();
            this.adbPathTextBox = new System.Windows.Forms.TextBox();
            this._settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraAppComboBox = new System.Windows.Forms.ComboBox();
            this._cameraTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.focusKeepaliveIntervalTextBox = new System.Windows.Forms.TextBox();
            this.pinCodeTextBox = new System.Windows.Forms.TextBox();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.deviceImageFolderTextBox = new System.Windows.Forms.TextBox();
            this.deleteAfterDownloadCheckBox = new System.Windows.Forms.CheckBox();
            this.workingFolderTextBox = new System.Windows.Forms.TextBox();
            this.fileSelectionRegexTextBox = new System.Windows.Forms.TextBox();
            this.publishFolderTextBox = new System.Windows.Forms.TextBox();
            this.publishFilenamePatternTextBox = new System.Windows.Forms.TextBox();
            this._resetButton = new System.Windows.Forms.Button();
            this._workingBrowseButton = new System.Windows.Forms.Button();
            this._publishBrowseButton = new System.Windows.Forms.Button();
            this.downloadImagesIntervalTextBox = new System.Windows.Forms.TextBox();
            this.publishFilesPerFolderTextBox = new System.Windows.Forms.TextBox();
            this._useNfcScreenApiCheckBox = new System.Windows.Forms.CheckBox();
            this._cameraOpenTimeoutCheckBox = new System.Windows.Forms.TextBox();
            adbPathLabel = new System.Windows.Forms.Label();
            cameraAppLabel = new System.Windows.Forms.Label();
            focusKeepaliveIntervalLabel = new System.Windows.Forms.Label();
            pinCodeLabel = new System.Windows.Forms.Label();
            deviceImageFolderLabel = new System.Windows.Forms.Label();
            deleteAfterDownloadLabel = new System.Windows.Forms.Label();
            workingFolderLabel = new System.Windows.Forms.Label();
            fileSelectionRegexLabel = new System.Windows.Forms.Label();
            publishFolderLabel = new System.Windows.Forms.Label();
            publishFilenamePatternLabel = new System.Windows.Forms.Label();
            downloadImagesIntervalLabel = new System.Windows.Forms.Label();
            publishFilesPerFolderLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cameraTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adbPathLabel
            // 
            adbPathLabel.AutoSize = true;
            adbPathLabel.Location = new System.Drawing.Point(8, 8);
            adbPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            adbPathLabel.Name = "adbPathLabel";
            adbPathLabel.Size = new System.Drawing.Size(54, 13);
            adbPathLabel.TabIndex = 0;
            adbPathLabel.Text = "Adb Path:";
            // 
            // cameraAppLabel
            // 
            cameraAppLabel.AutoSize = true;
            cameraAppLabel.Location = new System.Drawing.Point(8, 29);
            cameraAppLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cameraAppLabel.Name = "cameraAppLabel";
            cameraAppLabel.Size = new System.Drawing.Size(68, 13);
            cameraAppLabel.TabIndex = 3;
            cameraAppLabel.Text = "Camera App:";
            // 
            // focusKeepaliveIntervalLabel
            // 
            focusKeepaliveIntervalLabel.AutoSize = true;
            focusKeepaliveIntervalLabel.Location = new System.Drawing.Point(8, 73);
            focusKeepaliveIntervalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            focusKeepaliveIntervalLabel.Name = "focusKeepaliveIntervalLabel";
            focusKeepaliveIntervalLabel.Size = new System.Drawing.Size(127, 13);
            focusKeepaliveIntervalLabel.TabIndex = 7;
            focusKeepaliveIntervalLabel.Text = "Focus Keepalive Interval:";
            // 
            // pinCodeLabel
            // 
            pinCodeLabel.AutoSize = true;
            pinCodeLabel.Location = new System.Drawing.Point(8, 94);
            pinCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pinCodeLabel.Name = "pinCodeLabel";
            pinCodeLabel.Size = new System.Drawing.Size(102, 13);
            pinCodeLabel.TabIndex = 9;
            pinCodeLabel.Text = "Pin Code (or empty):";
            // 
            // deviceImageFolderLabel
            // 
            deviceImageFolderLabel.AutoSize = true;
            deviceImageFolderLabel.Location = new System.Drawing.Point(8, 115);
            deviceImageFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            deviceImageFolderLabel.Name = "deviceImageFolderLabel";
            deviceImageFolderLabel.Size = new System.Drawing.Size(108, 13);
            deviceImageFolderLabel.TabIndex = 11;
            deviceImageFolderLabel.Text = "Device Image Folder:";
            // 
            // deleteAfterDownloadLabel
            // 
            deleteAfterDownloadLabel.AutoSize = true;
            deleteAfterDownloadLabel.Location = new System.Drawing.Point(8, 134);
            deleteAfterDownloadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            deleteAfterDownloadLabel.Name = "deleteAfterDownloadLabel";
            deleteAfterDownloadLabel.Size = new System.Drawing.Size(117, 13);
            deleteAfterDownloadLabel.TabIndex = 13;
            deleteAfterDownloadLabel.Text = "Delete After Download:";
            // 
            // workingFolderLabel
            // 
            workingFolderLabel.AutoSize = true;
            workingFolderLabel.Location = new System.Drawing.Point(8, 176);
            workingFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            workingFolderLabel.Name = "workingFolderLabel";
            workingFolderLabel.Size = new System.Drawing.Size(82, 13);
            workingFolderLabel.TabIndex = 17;
            workingFolderLabel.Text = "Working Folder:";
            // 
            // fileSelectionRegexLabel
            // 
            fileSelectionRegexLabel.AutoSize = true;
            fileSelectionRegexLabel.Location = new System.Drawing.Point(8, 155);
            fileSelectionRegexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fileSelectionRegexLabel.Name = "fileSelectionRegexLabel";
            fileSelectionRegexLabel.Size = new System.Drawing.Size(107, 13);
            fileSelectionRegexLabel.TabIndex = 15;
            fileSelectionRegexLabel.Text = "File Selection Regex:";
            // 
            // publishFolderLabel
            // 
            publishFolderLabel.AutoSize = true;
            publishFolderLabel.Location = new System.Drawing.Point(8, 197);
            publishFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            publishFolderLabel.Name = "publishFolderLabel";
            publishFolderLabel.Size = new System.Drawing.Size(76, 13);
            publishFolderLabel.TabIndex = 20;
            publishFolderLabel.Text = "Publish Folder:";
            // 
            // publishFilenamePatternLabel
            // 
            publishFilenamePatternLabel.AutoSize = true;
            publishFilenamePatternLabel.Location = new System.Drawing.Point(8, 218);
            publishFilenamePatternLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            publishFilenamePatternLabel.Name = "publishFilenamePatternLabel";
            publishFilenamePatternLabel.Size = new System.Drawing.Size(126, 13);
            publishFilenamePatternLabel.TabIndex = 23;
            publishFilenamePatternLabel.Text = "Publish Filename Pattern:";
            // 
            // downloadImagesIntervalLabel
            // 
            downloadImagesIntervalLabel.AutoSize = true;
            downloadImagesIntervalLabel.Location = new System.Drawing.Point(8, 238);
            downloadImagesIntervalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            downloadImagesIntervalLabel.Name = "downloadImagesIntervalLabel";
            downloadImagesIntervalLabel.Size = new System.Drawing.Size(133, 13);
            downloadImagesIntervalLabel.TabIndex = 25;
            downloadImagesIntervalLabel.Text = "Download Images Interval:";
            // 
            // publishFilesPerFolderLabel
            // 
            publishFilesPerFolderLabel.AutoSize = true;
            publishFilesPerFolderLabel.Location = new System.Drawing.Point(8, 259);
            publishFilesPerFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            publishFilesPerFolderLabel.Name = "publishFilesPerFolderLabel";
            publishFilesPerFolderLabel.Size = new System.Drawing.Size(119, 13);
            publishFilesPerFolderLabel.TabIndex = 27;
            publishFilesPerFolderLabel.Text = "Publish Files Per Folder:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 53);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 13);
            label1.TabIndex = 5;
            label1.Text = "Use NFC screen api";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(160, 319);
            this._saveButton.Margin = new System.Windows.Forms.Padding(2);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(50, 23);
            this._saveButton.TabIndex = 29;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(214, 319);
            this._cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(50, 23);
            this._cancelButton.TabIndex = 30;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // _adbBrowseButton
            // 
            this._adbBrowseButton.Location = new System.Drawing.Point(480, 4);
            this._adbBrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this._adbBrowseButton.Name = "_adbBrowseButton";
            this._adbBrowseButton.Size = new System.Drawing.Size(50, 23);
            this._adbBrowseButton.TabIndex = 2;
            this._adbBrowseButton.Text = "Browse";
            this._adbBrowseButton.UseVisualStyleBackColor = true;
            this._adbBrowseButton.Click += new System.EventHandler(this.OnAdbBrowseButtonClick);
            // 
            // adbPathTextBox
            // 
            this.adbPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "AdbPath", true));
            this.adbPathTextBox.Location = new System.Drawing.Point(160, 6);
            this.adbPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adbPathTextBox.Name = "adbPathTextBox";
            this.adbPathTextBox.Size = new System.Drawing.Size(317, 20);
            this.adbPathTextBox.TabIndex = 1;
            // 
            // _settingsBindingSource
            // 
            this._settingsBindingSource.DataSource = typeof(System.Configuration.ApplicationSettingsBase);
            // 
            // cameraAppComboBox
            // 
            this.cameraAppComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._settingsBindingSource, "CameraApp", true));
            this.cameraAppComboBox.DataSource = this._cameraTypeBindingSource;
            this.cameraAppComboBox.DisplayMember = "Name";
            this.cameraAppComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraAppComboBox.FormattingEnabled = true;
            this.cameraAppComboBox.Location = new System.Drawing.Point(160, 27);
            this.cameraAppComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.cameraAppComboBox.Name = "cameraAppComboBox";
            this.cameraAppComboBox.Size = new System.Drawing.Size(317, 21);
            this.cameraAppComboBox.TabIndex = 4;
            this.cameraAppComboBox.ValueMember = "Action";
            // 
            // _cameraTypeBindingSource
            // 
            this._cameraTypeBindingSource.DataSource = typeof(Android_Photo_Booth.CameraType);
            // 
            // focusKeepaliveIntervalTextBox
            // 
            this.focusKeepaliveIntervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "FocusKeepaliveInterval", true));
            this.focusKeepaliveIntervalTextBox.Location = new System.Drawing.Point(160, 71);
            this.focusKeepaliveIntervalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.focusKeepaliveIntervalTextBox.Name = "focusKeepaliveIntervalTextBox";
            this.focusKeepaliveIntervalTextBox.Size = new System.Drawing.Size(317, 20);
            this.focusKeepaliveIntervalTextBox.TabIndex = 8;
            // 
            // pinCodeTextBox
            // 
            this.pinCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PinCode", true));
            this.pinCodeTextBox.Location = new System.Drawing.Point(160, 92);
            this.pinCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.pinCodeTextBox.Name = "pinCodeTextBox";
            this.pinCodeTextBox.Size = new System.Drawing.Size(317, 20);
            this.pinCodeTextBox.TabIndex = 10;
            // 
            // deviceImageFolderTextBox
            // 
            this.deviceImageFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceImageFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "DeviceImageFolder", true));
            this.deviceImageFolderTextBox.Location = new System.Drawing.Point(160, 113);
            this.deviceImageFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.deviceImageFolderTextBox.Name = "deviceImageFolderTextBox";
            this.deviceImageFolderTextBox.Size = new System.Drawing.Size(317, 20);
            this.deviceImageFolderTextBox.TabIndex = 12;
            // 
            // deleteAfterDownloadCheckBox
            // 
            this.deleteAfterDownloadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._settingsBindingSource, "DeleteAfterDownload", true));
            this.deleteAfterDownloadCheckBox.Location = new System.Drawing.Point(161, 134);
            this.deleteAfterDownloadCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAfterDownloadCheckBox.Name = "deleteAfterDownloadCheckBox";
            this.deleteAfterDownloadCheckBox.Size = new System.Drawing.Size(69, 16);
            this.deleteAfterDownloadCheckBox.TabIndex = 14;
            this.deleteAfterDownloadCheckBox.UseVisualStyleBackColor = true;
            // 
            // workingFolderTextBox
            // 
            this.workingFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "WorkingFolder", true));
            this.workingFolderTextBox.Location = new System.Drawing.Point(160, 174);
            this.workingFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workingFolderTextBox.Name = "workingFolderTextBox";
            this.workingFolderTextBox.Size = new System.Drawing.Size(317, 20);
            this.workingFolderTextBox.TabIndex = 18;
            // 
            // fileSelectionRegexTextBox
            // 
            this.fileSelectionRegexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectionRegexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "FileSelectionRegex", true));
            this.fileSelectionRegexTextBox.Location = new System.Drawing.Point(160, 153);
            this.fileSelectionRegexTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileSelectionRegexTextBox.Name = "fileSelectionRegexTextBox";
            this.fileSelectionRegexTextBox.Size = new System.Drawing.Size(317, 20);
            this.fileSelectionRegexTextBox.TabIndex = 16;
            // 
            // publishFolderTextBox
            // 
            this.publishFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PublishFolder", true));
            this.publishFolderTextBox.Location = new System.Drawing.Point(160, 195);
            this.publishFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.publishFolderTextBox.Name = "publishFolderTextBox";
            this.publishFolderTextBox.Size = new System.Drawing.Size(317, 20);
            this.publishFolderTextBox.TabIndex = 21;
            // 
            // publishFilenamePatternTextBox
            // 
            this.publishFilenamePatternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishFilenamePatternTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PublishFilenamePattern", true));
            this.publishFilenamePatternTextBox.Location = new System.Drawing.Point(160, 216);
            this.publishFilenamePatternTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.publishFilenamePatternTextBox.Name = "publishFilenamePatternTextBox";
            this.publishFilenamePatternTextBox.Size = new System.Drawing.Size(317, 20);
            this.publishFilenamePatternTextBox.TabIndex = 24;
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(268, 319);
            this._resetButton.Margin = new System.Windows.Forms.Padding(2);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(50, 23);
            this._resetButton.TabIndex = 31;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // _workingBrowseButton
            // 
            this._workingBrowseButton.Location = new System.Drawing.Point(480, 171);
            this._workingBrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this._workingBrowseButton.Name = "_workingBrowseButton";
            this._workingBrowseButton.Size = new System.Drawing.Size(50, 23);
            this._workingBrowseButton.TabIndex = 19;
            this._workingBrowseButton.Text = "Browse";
            this._workingBrowseButton.UseVisualStyleBackColor = true;
            this._workingBrowseButton.Click += new System.EventHandler(this.OnWorkingBrowseButtonClick);
            // 
            // _publishBrowseButton
            // 
            this._publishBrowseButton.Location = new System.Drawing.Point(480, 192);
            this._publishBrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this._publishBrowseButton.Name = "_publishBrowseButton";
            this._publishBrowseButton.Size = new System.Drawing.Size(50, 23);
            this._publishBrowseButton.TabIndex = 22;
            this._publishBrowseButton.Text = "Browse";
            this._publishBrowseButton.UseVisualStyleBackColor = true;
            this._publishBrowseButton.Click += new System.EventHandler(this.OnPublishBrowseButtonClick);
            // 
            // downloadImagesIntervalTextBox
            // 
            this.downloadImagesIntervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "DownloadImagesInterval", true));
            this.downloadImagesIntervalTextBox.Location = new System.Drawing.Point(160, 236);
            this.downloadImagesIntervalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.downloadImagesIntervalTextBox.Name = "downloadImagesIntervalTextBox";
            this.downloadImagesIntervalTextBox.Size = new System.Drawing.Size(317, 20);
            this.downloadImagesIntervalTextBox.TabIndex = 26;
            // 
            // publishFilesPerFolderTextBox
            // 
            this.publishFilesPerFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishFilesPerFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PublishFilesPerFolder", true));
            this.publishFilesPerFolderTextBox.Location = new System.Drawing.Point(160, 257);
            this.publishFilesPerFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.publishFilesPerFolderTextBox.Name = "publishFilesPerFolderTextBox";
            this.publishFilesPerFolderTextBox.Size = new System.Drawing.Size(317, 20);
            this.publishFilesPerFolderTextBox.TabIndex = 28;
            // 
            // _useNfcScreenApiCheckBox
            // 
            this._useNfcScreenApiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._settingsBindingSource, "UseNfcScreenApi", true));
            this._useNfcScreenApiCheckBox.Location = new System.Drawing.Point(160, 52);
            this._useNfcScreenApiCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this._useNfcScreenApiCheckBox.Name = "_useNfcScreenApiCheckBox";
            this._useNfcScreenApiCheckBox.Size = new System.Drawing.Size(69, 16);
            this._useNfcScreenApiCheckBox.TabIndex = 6;
            this._useNfcScreenApiCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 283);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 13);
            label2.TabIndex = 32;
            label2.Text = "Camera open timeout";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _cameraOpenTimeoutCheckBox
            // 
            this._cameraOpenTimeoutCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "CameraOpenTimeout", true));
            this._cameraOpenTimeoutCheckBox.Location = new System.Drawing.Point(160, 281);
            this._cameraOpenTimeoutCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this._cameraOpenTimeoutCheckBox.Name = "_cameraOpenTimeoutCheckBox";
            this._cameraOpenTimeoutCheckBox.Size = new System.Drawing.Size(317, 20);
            this._cameraOpenTimeoutCheckBox.TabIndex = 33;
            this._cameraOpenTimeoutCheckBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(543, 382);
            this.Controls.Add(label2);
            this.Controls.Add(this._cameraOpenTimeoutCheckBox);
            this.Controls.Add(label1);
            this.Controls.Add(this._useNfcScreenApiCheckBox);
            this.Controls.Add(publishFilesPerFolderLabel);
            this.Controls.Add(this.publishFilesPerFolderTextBox);
            this.Controls.Add(downloadImagesIntervalLabel);
            this.Controls.Add(this.downloadImagesIntervalTextBox);
            this.Controls.Add(this._publishBrowseButton);
            this.Controls.Add(this._workingBrowseButton);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(publishFilenamePatternLabel);
            this.Controls.Add(this.publishFilenamePatternTextBox);
            this.Controls.Add(publishFolderLabel);
            this.Controls.Add(this.publishFolderTextBox);
            this.Controls.Add(fileSelectionRegexLabel);
            this.Controls.Add(this.fileSelectionRegexTextBox);
            this.Controls.Add(workingFolderLabel);
            this.Controls.Add(this.workingFolderTextBox);
            this.Controls.Add(deleteAfterDownloadLabel);
            this.Controls.Add(this.deleteAfterDownloadCheckBox);
            this.Controls.Add(deviceImageFolderLabel);
            this.Controls.Add(this.deviceImageFolderTextBox);
            this.Controls.Add(adbPathLabel);
            this.Controls.Add(this.adbPathTextBox);
            this.Controls.Add(cameraAppLabel);
            this.Controls.Add(this.cameraAppComboBox);
            this.Controls.Add(focusKeepaliveIntervalLabel);
            this.Controls.Add(this.focusKeepaliveIntervalTextBox);
            this.Controls.Add(pinCodeLabel);
            this.Controls.Add(this.pinCodeTextBox);
            this.Controls.Add(this._adbBrowseButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.OnSettingsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this._settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cameraTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource _cameraTypeBindingSource;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _adbBrowseButton;
        private System.Windows.Forms.BindingSource _settingsBindingSource;
        private System.Windows.Forms.TextBox adbPathTextBox;
        private System.Windows.Forms.ComboBox cameraAppComboBox;
        private System.Windows.Forms.TextBox focusKeepaliveIntervalTextBox;
        private System.Windows.Forms.TextBox pinCodeTextBox;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
        private System.Windows.Forms.TextBox deviceImageFolderTextBox;
        private System.Windows.Forms.CheckBox deleteAfterDownloadCheckBox;
        private System.Windows.Forms.TextBox workingFolderTextBox;
        private System.Windows.Forms.TextBox fileSelectionRegexTextBox;
        private System.Windows.Forms.TextBox publishFolderTextBox;
        private System.Windows.Forms.TextBox publishFilenamePatternTextBox;
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.Button _workingBrowseButton;
        private System.Windows.Forms.Button _publishBrowseButton;
        private System.Windows.Forms.TextBox downloadImagesIntervalTextBox;
        private System.Windows.Forms.TextBox publishFilesPerFolderTextBox;
        private System.Windows.Forms.CheckBox _useNfcScreenApiCheckBox;
        private System.Windows.Forms.TextBox _cameraOpenTimeoutCheckBox;
    }
}