﻿namespace Android_Photo_Booth
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
            this.label1 = new System.Windows.Forms.Label();
            this._device = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._adbFolderTextBox = new System.Windows.Forms.TextBox();
            this._adbFolderPicker = new System.Windows.Forms.FolderBrowserDialog();
            this._browseFolderButton = new System.Windows.Forms.Button();
            this._detectDeviceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Device";
            // 
            // _device
            // 
            this._device.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._device.Location = new System.Drawing.Point(159, 31);
            this._device.Name = "_device";
            this._device.Size = new System.Drawing.Size(548, 20);
            this._device.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adb path";
            // 
            // _adbFolderTextBox
            // 
            this._adbFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._adbFolderTextBox.Location = new System.Drawing.Point(159, 5);
            this._adbFolderTextBox.Name = "_adbFolderTextBox";
            this._adbFolderTextBox.Size = new System.Drawing.Size(548, 20);
            this._adbFolderTextBox.TabIndex = 1;
            // 
            // _adbFolderPicker
            // 
            this._adbFolderPicker.ShowNewFolderButton = false;
            // 
            // _browseFolderButton
            // 
            this._browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._browseFolderButton.Location = new System.Drawing.Point(713, 3);
            this._browseFolderButton.Name = "_browseFolderButton";
            this._browseFolderButton.Size = new System.Drawing.Size(75, 23);
            this._browseFolderButton.TabIndex = 2;
            this._browseFolderButton.Text = "Browse";
            this._browseFolderButton.UseVisualStyleBackColor = true;
            this._browseFolderButton.Click += new System.EventHandler(this.OnBrowseFolderButtonClick);
            // 
            // _detectDeviceButton
            // 
            this._detectDeviceButton.Location = new System.Drawing.Point(713, 29);
            this._detectDeviceButton.Name = "_detectDeviceButton";
            this._detectDeviceButton.Size = new System.Drawing.Size(75, 23);
            this._detectDeviceButton.TabIndex = 5;
            this._detectDeviceButton.Text = "Detect";
            this._detectDeviceButton.UseVisualStyleBackColor = true;
            this._detectDeviceButton.Click += new System.EventHandler(this.OnDetectDeviceButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._detectDeviceButton);
            this.Controls.Add(this._browseFolderButton);
            this.Controls.Add(this._adbFolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._device);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Android Photo Booth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _device;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _adbFolderTextBox;
        private System.Windows.Forms.FolderBrowserDialog _adbFolderPicker;
        private System.Windows.Forms.Button _browseFolderButton;
        private System.Windows.Forms.Button _detectDeviceButton;
    }
}
