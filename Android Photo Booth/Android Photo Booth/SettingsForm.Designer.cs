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
            ((System.ComponentModel.ISupportInitialize)(this._settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cameraTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adbPathLabel
            // 
            adbPathLabel.AutoSize = true;
            adbPathLabel.Location = new System.Drawing.Point(12, 13);
            adbPathLabel.Name = "adbPathLabel";
            adbPathLabel.Size = new System.Drawing.Size(79, 20);
            adbPathLabel.TabIndex = 0;
            adbPathLabel.Text = "Adb Path:";
            // 
            // cameraAppLabel
            // 
            cameraAppLabel.AutoSize = true;
            cameraAppLabel.Location = new System.Drawing.Point(12, 45);
            cameraAppLabel.Name = "cameraAppLabel";
            cameraAppLabel.Size = new System.Drawing.Size(102, 20);
            cameraAppLabel.TabIndex = 3;
            cameraAppLabel.Text = "Camera App:";
            // 
            // focusKeepaliveIntervalLabel
            // 
            focusKeepaliveIntervalLabel.AutoSize = true;
            focusKeepaliveIntervalLabel.Location = new System.Drawing.Point(12, 79);
            focusKeepaliveIntervalLabel.Name = "focusKeepaliveIntervalLabel";
            focusKeepaliveIntervalLabel.Size = new System.Drawing.Size(185, 20);
            focusKeepaliveIntervalLabel.TabIndex = 5;
            focusKeepaliveIntervalLabel.Text = "Focus Keepalive Interval:";
            // 
            // pinCodeLabel
            // 
            pinCodeLabel.AutoSize = true;
            pinCodeLabel.Location = new System.Drawing.Point(12, 111);
            pinCodeLabel.Name = "pinCodeLabel";
            pinCodeLabel.Size = new System.Drawing.Size(152, 20);
            pinCodeLabel.TabIndex = 7;
            pinCodeLabel.Text = "Pin Code (or empty):";
            // 
            // deviceImageFolderLabel
            // 
            deviceImageFolderLabel.AutoSize = true;
            deviceImageFolderLabel.Location = new System.Drawing.Point(12, 143);
            deviceImageFolderLabel.Name = "deviceImageFolderLabel";
            deviceImageFolderLabel.Size = new System.Drawing.Size(159, 20);
            deviceImageFolderLabel.TabIndex = 9;
            deviceImageFolderLabel.Text = "Device Image Folder:";
            // 
            // deleteAfterDownloadLabel
            // 
            deleteAfterDownloadLabel.AutoSize = true;
            deleteAfterDownloadLabel.Location = new System.Drawing.Point(12, 173);
            deleteAfterDownloadLabel.Name = "deleteAfterDownloadLabel";
            deleteAfterDownloadLabel.Size = new System.Drawing.Size(174, 20);
            deleteAfterDownloadLabel.TabIndex = 11;
            deleteAfterDownloadLabel.Text = "Delete After Download:";
            // 
            // workingFolderLabel
            // 
            workingFolderLabel.AutoSize = true;
            workingFolderLabel.Location = new System.Drawing.Point(12, 237);
            workingFolderLabel.Name = "workingFolderLabel";
            workingFolderLabel.Size = new System.Drawing.Size(120, 20);
            workingFolderLabel.TabIndex = 15;
            workingFolderLabel.Text = "Working Folder:";
            // 
            // fileSelectionRegexLabel
            // 
            fileSelectionRegexLabel.AutoSize = true;
            fileSelectionRegexLabel.Location = new System.Drawing.Point(12, 205);
            fileSelectionRegexLabel.Name = "fileSelectionRegexLabel";
            fileSelectionRegexLabel.Size = new System.Drawing.Size(158, 20);
            fileSelectionRegexLabel.TabIndex = 13;
            fileSelectionRegexLabel.Text = "File Selection Regex:";
            // 
            // publishFolderLabel
            // 
            publishFolderLabel.AutoSize = true;
            publishFolderLabel.Location = new System.Drawing.Point(12, 269);
            publishFolderLabel.Name = "publishFolderLabel";
            publishFolderLabel.Size = new System.Drawing.Size(113, 20);
            publishFolderLabel.TabIndex = 18;
            publishFolderLabel.Text = "Publish Folder:";
            // 
            // publishFilenamePatternLabel
            // 
            publishFilenamePatternLabel.AutoSize = true;
            publishFilenamePatternLabel.Location = new System.Drawing.Point(12, 301);
            publishFilenamePatternLabel.Name = "publishFilenamePatternLabel";
            publishFilenamePatternLabel.Size = new System.Drawing.Size(189, 20);
            publishFilenamePatternLabel.TabIndex = 21;
            publishFilenamePatternLabel.Text = "Publish Filename Pattern:";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(240, 376);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 35);
            this._saveButton.TabIndex = 23;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(321, 376);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 35);
            this._cancelButton.TabIndex = 24;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // _adbBrowseButton
            // 
            this._adbBrowseButton.Location = new System.Drawing.Point(720, 6);
            this._adbBrowseButton.Name = "_adbBrowseButton";
            this._adbBrowseButton.Size = new System.Drawing.Size(75, 35);
            this._adbBrowseButton.TabIndex = 2;
            this._adbBrowseButton.Text = "Browse";
            this._adbBrowseButton.UseVisualStyleBackColor = true;
            this._adbBrowseButton.Click += new System.EventHandler(this.OnAdbBrowseButtonClick);
            // 
            // adbPathTextBox
            // 
            this.adbPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "AdbPath", true));
            this.adbPathTextBox.Location = new System.Drawing.Point(240, 10);
            this.adbPathTextBox.Name = "adbPathTextBox";
            this.adbPathTextBox.Size = new System.Drawing.Size(474, 26);
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
            this.cameraAppComboBox.Location = new System.Drawing.Point(240, 42);
            this.cameraAppComboBox.Name = "cameraAppComboBox";
            this.cameraAppComboBox.Size = new System.Drawing.Size(474, 28);
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
            this.focusKeepaliveIntervalTextBox.Location = new System.Drawing.Point(240, 76);
            this.focusKeepaliveIntervalTextBox.Name = "focusKeepaliveIntervalTextBox";
            this.focusKeepaliveIntervalTextBox.Size = new System.Drawing.Size(474, 26);
            this.focusKeepaliveIntervalTextBox.TabIndex = 6;
            // 
            // pinCodeTextBox
            // 
            this.pinCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PinCode", true));
            this.pinCodeTextBox.Location = new System.Drawing.Point(240, 108);
            this.pinCodeTextBox.Name = "pinCodeTextBox";
            this.pinCodeTextBox.Size = new System.Drawing.Size(474, 26);
            this.pinCodeTextBox.TabIndex = 8;
            // 
            // deviceImageFolderTextBox
            // 
            this.deviceImageFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceImageFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "DeviceImageFolder", true));
            this.deviceImageFolderTextBox.Location = new System.Drawing.Point(240, 140);
            this.deviceImageFolderTextBox.Name = "deviceImageFolderTextBox";
            this.deviceImageFolderTextBox.Size = new System.Drawing.Size(473, 26);
            this.deviceImageFolderTextBox.TabIndex = 10;
            // 
            // deleteAfterDownloadCheckBox
            // 
            this.deleteAfterDownloadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._settingsBindingSource, "DeleteAfterDownload", true));
            this.deleteAfterDownloadCheckBox.Location = new System.Drawing.Point(241, 172);
            this.deleteAfterDownloadCheckBox.Name = "deleteAfterDownloadCheckBox";
            this.deleteAfterDownloadCheckBox.Size = new System.Drawing.Size(104, 24);
            this.deleteAfterDownloadCheckBox.TabIndex = 12;
            this.deleteAfterDownloadCheckBox.UseVisualStyleBackColor = true;
            // 
            // workingFolderTextBox
            // 
            this.workingFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workingFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "WorkingFolder", true));
            this.workingFolderTextBox.Location = new System.Drawing.Point(240, 234);
            this.workingFolderTextBox.Name = "workingFolderTextBox";
            this.workingFolderTextBox.Size = new System.Drawing.Size(473, 26);
            this.workingFolderTextBox.TabIndex = 16;
            // 
            // fileSelectionRegexTextBox
            // 
            this.fileSelectionRegexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelectionRegexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "FileSelectionRegex", true));
            this.fileSelectionRegexTextBox.Location = new System.Drawing.Point(240, 202);
            this.fileSelectionRegexTextBox.Name = "fileSelectionRegexTextBox";
            this.fileSelectionRegexTextBox.Size = new System.Drawing.Size(473, 26);
            this.fileSelectionRegexTextBox.TabIndex = 14;
            // 
            // publishFolderTextBox
            // 
            this.publishFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PublishFolder", true));
            this.publishFolderTextBox.Location = new System.Drawing.Point(240, 266);
            this.publishFolderTextBox.Name = "publishFolderTextBox";
            this.publishFolderTextBox.Size = new System.Drawing.Size(473, 26);
            this.publishFolderTextBox.TabIndex = 19;
            // 
            // publishFilenamePatternTextBox
            // 
            this.publishFilenamePatternTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publishFilenamePatternTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PublishFilenamePattern", true));
            this.publishFilenamePatternTextBox.Location = new System.Drawing.Point(240, 298);
            this.publishFilenamePatternTextBox.Name = "publishFilenamePatternTextBox";
            this.publishFilenamePatternTextBox.Size = new System.Drawing.Size(473, 26);
            this.publishFilenamePatternTextBox.TabIndex = 22;
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(402, 376);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(75, 35);
            this._resetButton.TabIndex = 25;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this.OnResetButtonClick);
            // 
            // _workingBrowseButton
            // 
            this._workingBrowseButton.Location = new System.Drawing.Point(720, 230);
            this._workingBrowseButton.Name = "_workingBrowseButton";
            this._workingBrowseButton.Size = new System.Drawing.Size(75, 35);
            this._workingBrowseButton.TabIndex = 17;
            this._workingBrowseButton.Text = "Browse";
            this._workingBrowseButton.UseVisualStyleBackColor = true;
            this._workingBrowseButton.Click += new System.EventHandler(this.OnWorkingBrowseButtonClick);
            // 
            // _publishBrowseButton
            // 
            this._publishBrowseButton.Location = new System.Drawing.Point(720, 262);
            this._publishBrowseButton.Name = "_publishBrowseButton";
            this._publishBrowseButton.Size = new System.Drawing.Size(75, 35);
            this._publishBrowseButton.TabIndex = 20;
            this._publishBrowseButton.Text = "Browse";
            this._publishBrowseButton.UseVisualStyleBackColor = true;
            this._publishBrowseButton.Click += new System.EventHandler(this.OnPublishBrowseButtonClick);
            // 
            // downloadImagesIntervalLabel
            // 
            downloadImagesIntervalLabel.AutoSize = true;
            downloadImagesIntervalLabel.Location = new System.Drawing.Point(12, 333);
            downloadImagesIntervalLabel.Name = "downloadImagesIntervalLabel";
            downloadImagesIntervalLabel.Size = new System.Drawing.Size(197, 20);
            downloadImagesIntervalLabel.TabIndex = 26;
            downloadImagesIntervalLabel.Text = "Download Images Interval:";
            // 
            // downloadImagesIntervalTextBox
            // 
            this.downloadImagesIntervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "DownloadImagesInterval", true));
            this.downloadImagesIntervalTextBox.Location = new System.Drawing.Point(240, 330);
            this.downloadImagesIntervalTextBox.Name = "downloadImagesIntervalTextBox";
            this.downloadImagesIntervalTextBox.Size = new System.Drawing.Size(474, 26);
            this.downloadImagesIntervalTextBox.TabIndex = 27;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(815, 587);
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
    }
}