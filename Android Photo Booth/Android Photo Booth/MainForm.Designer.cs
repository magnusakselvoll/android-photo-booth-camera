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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this._deviceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._adbFolderTextBox = new System.Windows.Forms.TextBox();
            this._adbFolderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this._browseFolderButton = new System.Windows.Forms.Button();
            this._detectDeviceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._pinTextBox = new System.Windows.Forms.TextBox();
            this._openCameraButton = new System.Windows.Forms.Button();
            this._focusButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device";
            // 
            // _deviceTextBox
            // 
            this._deviceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._deviceTextBox.Location = new System.Drawing.Point(238, 150);
            this._deviceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._deviceTextBox.Name = "_deviceTextBox";
            this._deviceTextBox.Size = new System.Drawing.Size(820, 26);
            this._deviceTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adb path";
            // 
            // _adbFolderTextBox
            // 
            this._adbFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._adbFolderTextBox.Location = new System.Drawing.Point(238, 110);
            this._adbFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._adbFolderTextBox.Name = "_adbFolderTextBox";
            this._adbFolderTextBox.Size = new System.Drawing.Size(820, 26);
            this._adbFolderTextBox.TabIndex = 1;
            // 
            // _adbFolderPicker
            // 
            this._adbFolderPicker.ShowNewFolderButton = false;
            // 
            // _browseFolderButton
            // 
            this._browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._browseFolderButton.Location = new System.Drawing.Point(1070, 107);
            this._browseFolderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._browseFolderButton.Name = "_browseFolderButton";
            this._browseFolderButton.Size = new System.Drawing.Size(112, 35);
            this._browseFolderButton.TabIndex = 2;
            this._browseFolderButton.Text = "Browse";
            this._browseFolderButton.UseVisualStyleBackColor = true;
            this._browseFolderButton.Click += new System.EventHandler(this.OnBrowseFolderButtonClick);
            // 
            // _detectDeviceButton
            // 
            this._detectDeviceButton.Location = new System.Drawing.Point(1070, 147);
            this._detectDeviceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._detectDeviceButton.Name = "_detectDeviceButton";
            this._detectDeviceButton.Size = new System.Drawing.Size(112, 35);
            this._detectDeviceButton.TabIndex = 5;
            this._detectDeviceButton.Text = "Detect";
            this._detectDeviceButton.UseVisualStyleBackColor = true;
            this._detectDeviceButton.Click += new System.EventHandler(this.OnDetectDeviceButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "PIN code (or empty)";
            // 
            // _pinTextBox
            // 
            this._pinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pinTextBox.Location = new System.Drawing.Point(238, 190);
            this._pinTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._pinTextBox.Name = "_pinTextBox";
            this._pinTextBox.Size = new System.Drawing.Size(820, 26);
            this._pinTextBox.TabIndex = 7;
            // 
            // _openCameraButton
            // 
            this._openCameraButton.Location = new System.Drawing.Point(238, 344);
            this._openCameraButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._openCameraButton.Name = "_openCameraButton";
            this._openCameraButton.Size = new System.Drawing.Size(136, 35);
            this._openCameraButton.TabIndex = 8;
            this._openCameraButton.Text = "Open  camera";
            this._openCameraButton.UseVisualStyleBackColor = true;
            this._openCameraButton.Click += new System.EventHandler(this.OnOpenCameraButtonClickAsync);
            // 
            // _focusButton
            // 
            this._focusButton.Location = new System.Drawing.Point(384, 344);
            this._focusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._focusButton.Name = "_focusButton";
            this._focusButton.Size = new System.Drawing.Size(112, 35);
            this._focusButton.TabIndex = 9;
            this._focusButton.Text = "Focus";
            this._focusButton.UseVisualStyleBackColor = true;
            this._focusButton.Click += new System.EventHandler(this.OnFocusButtonClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._settingsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 32);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _settingsButton
            // 
            this._settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("_settingsButton.Image")));
            this._settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._settingsButton.Name = "_settingsButton";
            this._settingsButton.Size = new System.Drawing.Size(80, 29);
            this._settingsButton.Text = "Settings";
            this._settingsButton.Click += new System.EventHandler(this.OnSettingsButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._focusButton);
            this.Controls.Add(this._openCameraButton);
            this.Controls.Add(this._pinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._detectDeviceButton);
            this.Controls.Add(this._browseFolderButton);
            this.Controls.Add(this._adbFolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._deviceTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Android Photo Booth";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _deviceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _adbFolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog _adbFolderPicker;
        private System.Windows.Forms.Button _browseFolderButton;
        private System.Windows.Forms.Button _detectDeviceButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _pinTextBox;
        private System.Windows.Forms.Button _openCameraButton;
        private System.Windows.Forms.Button _focusButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _settingsButton;
    }
}

