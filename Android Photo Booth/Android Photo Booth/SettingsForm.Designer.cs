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
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._browseButton = new System.Windows.Forms.Button();
            this.adbPathTextBox = new System.Windows.Forms.TextBox();
            this._settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cameraAppComboBox = new System.Windows.Forms.ComboBox();
            this._cameraTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.focusKeepaliveIntervalTextBox = new System.Windows.Forms.TextBox();
            this.pinCodeTextBox = new System.Windows.Forms.TextBox();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            adbPathLabel = new System.Windows.Forms.Label();
            cameraAppLabel = new System.Windows.Forms.Label();
            focusKeepaliveIntervalLabel = new System.Windows.Forms.Label();
            pinCodeLabel = new System.Windows.Forms.Label();
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
            adbPathLabel.TabIndex = 20;
            adbPathLabel.Text = "Adb Path:";
            // 
            // cameraAppLabel
            // 
            cameraAppLabel.AutoSize = true;
            cameraAppLabel.Location = new System.Drawing.Point(12, 45);
            cameraAppLabel.Name = "cameraAppLabel";
            cameraAppLabel.Size = new System.Drawing.Size(102, 20);
            cameraAppLabel.TabIndex = 22;
            cameraAppLabel.Text = "Camera App:";
            // 
            // focusKeepaliveIntervalLabel
            // 
            focusKeepaliveIntervalLabel.AutoSize = true;
            focusKeepaliveIntervalLabel.Location = new System.Drawing.Point(12, 79);
            focusKeepaliveIntervalLabel.Name = "focusKeepaliveIntervalLabel";
            focusKeepaliveIntervalLabel.Size = new System.Drawing.Size(185, 20);
            focusKeepaliveIntervalLabel.TabIndex = 24;
            focusKeepaliveIntervalLabel.Text = "Focus Keepalive Interval:";
            // 
            // pinCodeLabel
            // 
            pinCodeLabel.AutoSize = true;
            pinCodeLabel.Location = new System.Drawing.Point(12, 111);
            pinCodeLabel.Name = "pinCodeLabel";
            pinCodeLabel.Size = new System.Drawing.Size(152, 20);
            pinCodeLabel.TabIndex = 26;
            pinCodeLabel.Text = "Pin Code (or empty):";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(240, 271);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 35);
            this._saveButton.TabIndex = 11;
            this._saveButton.Text = "Save";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(321, 271);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 35);
            this._cancelButton.TabIndex = 12;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(720, 6);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(75, 35);
            this._browseButton.TabIndex = 20;
            this._browseButton.Text = "Browse";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // adbPathTextBox
            // 
            this.adbPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "AdbPath", true));
            this.adbPathTextBox.Location = new System.Drawing.Point(240, 10);
            this.adbPathTextBox.Name = "adbPathTextBox";
            this.adbPathTextBox.Size = new System.Drawing.Size(474, 26);
            this.adbPathTextBox.TabIndex = 21;
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
            this.cameraAppComboBox.TabIndex = 23;
            this.cameraAppComboBox.ValueMember = "Action";
            this.cameraAppComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.CameraAppComboBox_Validating);
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
            this.focusKeepaliveIntervalTextBox.TabIndex = 25;
            // 
            // pinCodeTextBox
            // 
            this.pinCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._settingsBindingSource, "PinCode", true));
            this.pinCodeTextBox.Location = new System.Drawing.Point(240, 108);
            this.pinCodeTextBox.Name = "pinCodeTextBox";
            this.pinCodeTextBox.Size = new System.Drawing.Size(474, 26);
            this.pinCodeTextBox.TabIndex = 27;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(adbPathLabel);
            this.Controls.Add(this.adbPathTextBox);
            this.Controls.Add(cameraAppLabel);
            this.Controls.Add(this.cameraAppComboBox);
            this.Controls.Add(focusKeepaliveIntervalLabel);
            this.Controls.Add(this.focusKeepaliveIntervalTextBox);
            this.Controls.Add(pinCodeLabel);
            this.Controls.Add(this.pinCodeTextBox);
            this.Controls.Add(this._browseButton);
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
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.BindingSource _settingsBindingSource;
        private System.Windows.Forms.TextBox adbPathTextBox;
        private System.Windows.Forms.ComboBox cameraAppComboBox;
        private System.Windows.Forms.TextBox focusKeepaliveIntervalTextBox;
        private System.Windows.Forms.TextBox pinCodeTextBox;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
    }
}