namespace Android_Photo_Booth
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this._deviceTextBox = new System.Windows.Forms.TextBox();
            this._detectDeviceButton = new System.Windows.Forms.Button();
            this._openCameraButton = new System.Windows.Forms.Button();
            this._focusButton = new System.Windows.Forms.Button();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._settingsButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this._stopJoystickButton = new System.Windows.Forms.Button();
            this._startJoystickButton = new System.Windows.Forms.Button();
            this._takeSinglePhotoButton = new System.Windows.Forms.Button();
            this._logTextBox = new System.Windows.Forms.TextBox();
            this._downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this._downloadButton = new System.Windows.Forms.Button();
            this._focusProgressBar = new System.Windows.Forms.ProgressBar();
            this._focusTimer = new System.Windows.Forms.Timer(this.components);
            this._downloadTimer = new System.Windows.Forms.Timer(this.components);
            this._toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device";
            // 
            // _deviceTextBox
            // 
            this._deviceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._deviceTextBox.Location = new System.Drawing.Point(90, 6);
            this._deviceTextBox.Name = "_deviceTextBox";
            this._deviceTextBox.ReadOnly = true;
            this._deviceTextBox.Size = new System.Drawing.Size(543, 20);
            this._deviceTextBox.TabIndex = 4;
            // 
            // _detectDeviceButton
            // 
            this._detectDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._detectDeviceButton.Location = new System.Drawing.Point(637, 4);
            this._detectDeviceButton.Name = "_detectDeviceButton";
            this._detectDeviceButton.Size = new System.Drawing.Size(75, 23);
            this._detectDeviceButton.TabIndex = 5;
            this._detectDeviceButton.Text = "Detect";
            this._detectDeviceButton.UseVisualStyleBackColor = true;
            this._detectDeviceButton.Click += new System.EventHandler(this.OnDetectDeviceButtonClickAsync);
            // 
            // _openCameraButton
            // 
            this._openCameraButton.Location = new System.Drawing.Point(90, 53);
            this._openCameraButton.Name = "_openCameraButton";
            this._openCameraButton.Size = new System.Drawing.Size(91, 23);
            this._openCameraButton.TabIndex = 8;
            this._openCameraButton.Text = "Open  camera";
            this._openCameraButton.UseVisualStyleBackColor = true;
            this._openCameraButton.Click += new System.EventHandler(this.OnOpenCameraButtonClickAsync);
            // 
            // _focusButton
            // 
            this._focusButton.Location = new System.Drawing.Point(90, 83);
            this._focusButton.Name = "_focusButton";
            this._focusButton.Size = new System.Drawing.Size(91, 23);
            this._focusButton.TabIndex = 9;
            this._focusButton.Text = "Focus loop";
            this._focusButton.UseVisualStyleBackColor = true;
            this._focusButton.Click += new System.EventHandler(this.OnFocusButtonClick);
            // 
            // _toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._settingsButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(720, 25);
            this._toolStrip.TabIndex = 10;
            // 
            // _settingsButton
            // 
            this._settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("_settingsButton.Image")));
            this._settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._settingsButton.Name = "_settingsButton";
            this._settingsButton.Size = new System.Drawing.Size(53, 22);
            this._settingsButton.Text = "Settings";
            this._settingsButton.Click += new System.EventHandler(this.OnSettingsButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._stopJoystickButton);
            this.panel1.Controls.Add(this._startJoystickButton);
            this.panel1.Controls.Add(this._takeSinglePhotoButton);
            this.panel1.Controls.Add(this._logTextBox);
            this.panel1.Controls.Add(this._downloadProgressBar);
            this.panel1.Controls.Add(this._downloadButton);
            this.panel1.Controls.Add(this._focusProgressBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._deviceTextBox);
            this.panel1.Controls.Add(this._focusButton);
            this.panel1.Controls.Add(this._detectDeviceButton);
            this.panel1.Controls.Add(this._openCameraButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 425);
            this.panel1.TabIndex = 11;
            // 
            // _stopJoystickButton
            // 
            this._stopJoystickButton.Enabled = false;
            this._stopJoystickButton.Location = new System.Drawing.Point(435, 53);
            this._stopJoystickButton.Name = "_stopJoystickButton";
            this._stopJoystickButton.Size = new System.Drawing.Size(118, 23);
            this._stopJoystickButton.TabIndex = 16;
            this._stopJoystickButton.Text = "Stop joystick";
            this._stopJoystickButton.UseVisualStyleBackColor = true;
            this._stopJoystickButton.Click += new System.EventHandler(this.OnStopJoystickButtonClicked);
            // 
            // _startJoystickButton
            // 
            this._startJoystickButton.Location = new System.Drawing.Point(311, 53);
            this._startJoystickButton.Name = "_startJoystickButton";
            this._startJoystickButton.Size = new System.Drawing.Size(118, 23);
            this._startJoystickButton.TabIndex = 15;
            this._startJoystickButton.Text = "Start joystick";
            this._startJoystickButton.UseVisualStyleBackColor = true;
            this._startJoystickButton.Click += new System.EventHandler(this.OnStartJoystickButtonClicked);
            // 
            // _takeSinglePhotoButton
            // 
            this._takeSinglePhotoButton.Location = new System.Drawing.Point(187, 53);
            this._takeSinglePhotoButton.Name = "_takeSinglePhotoButton";
            this._takeSinglePhotoButton.Size = new System.Drawing.Size(118, 23);
            this._takeSinglePhotoButton.TabIndex = 14;
            this._takeSinglePhotoButton.Text = "Take single photo";
            this._takeSinglePhotoButton.UseVisualStyleBackColor = true;
            this._takeSinglePhotoButton.Click += new System.EventHandler(this.OnTakeSinglePhotoButtonClickedAsync);
            // 
            // _logTextBox
            // 
            this._logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._logTextBox.Location = new System.Drawing.Point(90, 250);
            this._logTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._logTextBox.Multiline = true;
            this._logTextBox.Name = "_logTextBox";
            this._logTextBox.ReadOnly = true;
            this._logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._logTextBox.Size = new System.Drawing.Size(543, 169);
            this._logTextBox.TabIndex = 13;
            // 
            // _downloadProgressBar
            // 
            this._downloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._downloadProgressBar.Location = new System.Drawing.Point(185, 112);
            this._downloadProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this._downloadProgressBar.Name = "_downloadProgressBar";
            this._downloadProgressBar.Size = new System.Drawing.Size(446, 23);
            this._downloadProgressBar.TabIndex = 12;
            // 
            // _downloadButton
            // 
            this._downloadButton.Location = new System.Drawing.Point(90, 112);
            this._downloadButton.Name = "_downloadButton";
            this._downloadButton.Size = new System.Drawing.Size(91, 23);
            this._downloadButton.TabIndex = 11;
            this._downloadButton.Text = "Download loop";
            this._downloadButton.UseVisualStyleBackColor = true;
            this._downloadButton.Click += new System.EventHandler(this.OnDownloadButtonClick);
            // 
            // _focusProgressBar
            // 
            this._focusProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._focusProgressBar.Location = new System.Drawing.Point(185, 83);
            this._focusProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this._focusProgressBar.Name = "_focusProgressBar";
            this._focusProgressBar.Size = new System.Drawing.Size(446, 23);
            this._focusProgressBar.TabIndex = 10;
            // 
            // _focusTimer
            // 
            this._focusTimer.Tick += new System.EventHandler(this.OnFocusTimerTickAsync);
            // 
            // _downloadTimer
            // 
            this._downloadTimer.Tick += new System.EventHandler(this.OnDownloadTimerTickAsync);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._toolStrip);
            this.Name = "MainForm";
            this.Text = "Android Photo Booth";
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _deviceTextBox;
        private System.Windows.Forms.Button _detectDeviceButton;
        private System.Windows.Forms.Button _openCameraButton;
        private System.Windows.Forms.Button _focusButton;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _settingsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar _focusProgressBar;
        private System.Windows.Forms.Timer _focusTimer;
        private System.Windows.Forms.ProgressBar _downloadProgressBar;
        private System.Windows.Forms.Button _downloadButton;
        private System.Windows.Forms.Timer _downloadTimer;
        private System.Windows.Forms.TextBox _logTextBox;
        private System.Windows.Forms.Button _takeSinglePhotoButton;
        private System.Windows.Forms.Button _stopJoystickButton;
        private System.Windows.Forms.Button _startJoystickButton;
    }
}

