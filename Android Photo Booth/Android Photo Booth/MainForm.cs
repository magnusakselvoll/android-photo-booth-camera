using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_Photo_Booth
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnBrowseFolderButtonClick(object sender, EventArgs e)
        {
            var result = _adbFolderPicker.ShowDialog();

            if (result == DialogResult.OK)
            {
                _adbFolderTextBox.Text = _adbFolderPicker.SelectedPath;
            }
        }

        private void OnDetectDeviceButtonClick(object sender, EventArgs e)
        {
            if (!TryGetAdbExecutablePath(out string adbExePath))
            {
                ShowBadAdbPathDialog();
                return;
            }
        }

        private void ShowBadAdbPathDialog()
        {
            MessageBox.Show("The file adb.exe cannot be found at the given path. Please select the correct folder and try again.", "Incorrect adb path",
                MessageBoxButtons.OK);
        }

        private bool TryGetAdbExecutablePath(out string adbExePath)
        {
            adbExePath = Path.Combine(_adbFolderTextBox.Text, "adb.exe");

            if (File.Exists(adbExePath)) return true;
            adbExePath = null;
            return false;
        }
    }
}
