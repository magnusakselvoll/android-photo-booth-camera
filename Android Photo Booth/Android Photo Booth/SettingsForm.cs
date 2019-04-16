using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Photo_Booth.Properties;

namespace Android_Photo_Booth
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void OnSettingsFormActivated(object sender, EventArgs e)
        {
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            Close();
        }

        private void OnSettingsFormLoad(object sender, EventArgs e)
        {
            settingsBindingSource.DataSource = Settings.Default;

        }
    }
}
