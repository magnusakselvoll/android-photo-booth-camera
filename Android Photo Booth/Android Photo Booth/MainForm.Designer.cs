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
            this._focusProgressBar = new System.Windows.Forms.ProgressBar();
            this._focusTimer = new System.Windows.Forms.Timer(this.components);
            this._toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
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
            this._deviceTextBox.Location = new System.Drawing.Point(135, 10);
            this._deviceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._deviceTextBox.Name = "_deviceTextBox";
            this._deviceTextBox.ReadOnly = true;
            this._deviceTextBox.Size = new System.Drawing.Size(812, 26);
            this._deviceTextBox.TabIndex = 4;
            // 
            // _detectDeviceButton
            // 
            this._detectDeviceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._detectDeviceButton.Location = new System.Drawing.Point(955, 6);
            this._detectDeviceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._detectDeviceButton.Name = "_detectDeviceButton";
            this._detectDeviceButton.Size = new System.Drawing.Size(112, 35);
            this._detectDeviceButton.TabIndex = 5;
            this._detectDeviceButton.Text = "Detect";
            this._detectDeviceButton.UseVisualStyleBackColor = true;
            this._detectDeviceButton.Click += new System.EventHandler(this.OnDetectDeviceButtonClick);
            // 
            // _openCameraButton
            // 
            this._openCameraButton.Location = new System.Drawing.Point(135, 82);
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
            this._focusButton.Location = new System.Drawing.Point(135, 127);
            this._focusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._focusButton.Name = "_focusButton";
            this._focusButton.Size = new System.Drawing.Size(136, 35);
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
            this._toolStrip.Size = new System.Drawing.Size(1080, 32);
            this._toolStrip.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.Controls.Add(this._focusProgressBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._deviceTextBox);
            this.panel1.Controls.Add(this._focusButton);
            this.panel1.Controls.Add(this._detectDeviceButton);
            this.panel1.Controls.Add(this._openCameraButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 660);
            this.panel1.TabIndex = 11;
            // 
            // _focusProgressBar
            // 
            this._focusProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._focusProgressBar.Location = new System.Drawing.Point(278, 127);
            this._focusProgressBar.Name = "_focusProgressBar";
            this._focusProgressBar.Size = new System.Drawing.Size(669, 35);
            this._focusProgressBar.Step = 1;
            this._focusProgressBar.TabIndex = 10;
            // 
            // _focusTimer
            // 
            this._focusTimer.Tick += new System.EventHandler(this.OnFocusTimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._toolStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

