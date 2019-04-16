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
            System.Windows.Forms.Label settingLabel;
            this.cameraTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adbPathTextBox = new System.Windows.Forms.TextBox();
            this.cameraAppTextBox = new System.Windows.Forms.TextBox();
            this.focusKeepaliveIntervalTextBox = new System.Windows.Forms.TextBox();
            this.pinCodeTextBox = new System.Windows.Forms.TextBox();
            this.settingTextBox = new System.Windows.Forms.TextBox();
            adbPathLabel = new System.Windows.Forms.Label();
            cameraAppLabel = new System.Windows.Forms.Label();
            focusKeepaliveIntervalLabel = new System.Windows.Forms.Label();
            pinCodeLabel = new System.Windows.Forms.Label();
            settingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adbPathLabel
            // 
            adbPathLabel.AutoSize = true;
            adbPathLabel.Location = new System.Drawing.Point(480, 159);
            adbPathLabel.Name = "adbPathLabel";
            adbPathLabel.Size = new System.Drawing.Size(79, 20);
            adbPathLabel.TabIndex = 12;
            adbPathLabel.Text = "Adb Path:";
            // 
            // cameraAppLabel
            // 
            cameraAppLabel.AutoSize = true;
            cameraAppLabel.Location = new System.Drawing.Point(480, 191);
            cameraAppLabel.Name = "cameraAppLabel";
            cameraAppLabel.Size = new System.Drawing.Size(102, 20);
            cameraAppLabel.TabIndex = 14;
            cameraAppLabel.Text = "Camera App:";
            // 
            // focusKeepaliveIntervalLabel
            // 
            focusKeepaliveIntervalLabel.AutoSize = true;
            focusKeepaliveIntervalLabel.Location = new System.Drawing.Point(480, 223);
            focusKeepaliveIntervalLabel.Name = "focusKeepaliveIntervalLabel";
            focusKeepaliveIntervalLabel.Size = new System.Drawing.Size(185, 20);
            focusKeepaliveIntervalLabel.TabIndex = 16;
            focusKeepaliveIntervalLabel.Text = "Focus Keepalive Interval:";
            // 
            // pinCodeLabel
            // 
            pinCodeLabel.AutoSize = true;
            pinCodeLabel.Location = new System.Drawing.Point(480, 255);
            pinCodeLabel.Name = "pinCodeLabel";
            pinCodeLabel.Size = new System.Drawing.Size(77, 20);
            pinCodeLabel.TabIndex = 18;
            pinCodeLabel.Text = "Pin Code:";
            // 
            // settingLabel
            // 
            settingLabel.AutoSize = true;
            settingLabel.Location = new System.Drawing.Point(480, 287);
            settingLabel.Name = "settingLabel";
            settingLabel.Size = new System.Drawing.Size(64, 20);
            settingLabel.TabIndex = 20;
            settingLabel.Text = "Setting:";
            // 
            // cameraTypeBindingSource
            // 
            this.cameraTypeBindingSource.DataSource = typeof(Android_Photo_Booth.CameraType);
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
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(System.Configuration.ApplicationSettingsBase);
            // 
            // adbPathTextBox
            // 
            this.adbPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "AdbPath", true));
            this.adbPathTextBox.Location = new System.Drawing.Point(671, 156);
            this.adbPathTextBox.Name = "adbPathTextBox";
            this.adbPathTextBox.Size = new System.Drawing.Size(100, 26);
            this.adbPathTextBox.TabIndex = 13;
            // 
            // cameraAppTextBox
            // 
            this.cameraAppTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "CameraApp", true));
            this.cameraAppTextBox.Location = new System.Drawing.Point(671, 188);
            this.cameraAppTextBox.Name = "cameraAppTextBox";
            this.cameraAppTextBox.Size = new System.Drawing.Size(100, 26);
            this.cameraAppTextBox.TabIndex = 15;
            // 
            // focusKeepaliveIntervalTextBox
            // 
            this.focusKeepaliveIntervalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "FocusKeepaliveInterval", true));
            this.focusKeepaliveIntervalTextBox.Location = new System.Drawing.Point(671, 220);
            this.focusKeepaliveIntervalTextBox.Name = "focusKeepaliveIntervalTextBox";
            this.focusKeepaliveIntervalTextBox.Size = new System.Drawing.Size(100, 26);
            this.focusKeepaliveIntervalTextBox.TabIndex = 17;
            // 
            // pinCodeTextBox
            // 
            this.pinCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "PinCode", true));
            this.pinCodeTextBox.Location = new System.Drawing.Point(671, 252);
            this.pinCodeTextBox.Name = "pinCodeTextBox";
            this.pinCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.pinCodeTextBox.TabIndex = 19;
            // 
            // settingTextBox
            // 
            this.settingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Setting", true));
            this.settingTextBox.Location = new System.Drawing.Point(671, 284);
            this.settingTextBox.Name = "settingTextBox";
            this.settingTextBox.Size = new System.Drawing.Size(100, 26);
            this.settingTextBox.TabIndex = 21;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(adbPathLabel);
            this.Controls.Add(this.adbPathTextBox);
            this.Controls.Add(cameraAppLabel);
            this.Controls.Add(this.cameraAppTextBox);
            this.Controls.Add(focusKeepaliveIntervalLabel);
            this.Controls.Add(this.focusKeepaliveIntervalTextBox);
            this.Controls.Add(pinCodeLabel);
            this.Controls.Add(this.pinCodeTextBox);
            this.Controls.Add(settingLabel);
            this.Controls.Add(this.settingTextBox);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._saveButton);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Activated += new System.EventHandler(this.OnSettingsFormActivated);
            this.Load += new System.EventHandler(this.OnSettingsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.cameraTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cameraTypeBindingSource;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.TextBox adbPathTextBox;
        private System.Windows.Forms.TextBox cameraAppTextBox;
        private System.Windows.Forms.TextBox focusKeepaliveIntervalTextBox;
        private System.Windows.Forms.TextBox pinCodeTextBox;
        private System.Windows.Forms.TextBox settingTextBox;
    }
}