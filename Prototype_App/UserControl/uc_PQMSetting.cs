using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_App
{
    public partial class uc_PQMSetting : UserControl
    {
        public uc_PQMSetting()
        {
            InitializeComponent();
        }

        private void uc_PQMSetting_Load(object sender, EventArgs e)
        {
            txtBoxURL.Text = Properties.Settings.Default.URL;
            txtBoxInterfaceID.Text = Properties.Settings.Default.InterfaceID;
            checkMES.Checked = Properties.Settings.Default.EnableMES;
        }

        public void Enable_textbox()
        {
            txtBoxInterfaceID.Enabled = true;
            txtBoxURL.Enabled = true;

        }

        private void checkMES_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = txtBoxURL.Text;
            Properties.Settings.Default.InterfaceID = txtBoxInterfaceID.Text;
            Properties.Settings.Default.EnableMES = checkMES.Checked;

            Properties.Settings.Default.Save();
        }

        private void lbLoad_Click(object sender, EventArgs e)
        {
            txtBoxURL.Text = Properties.Settings.Default.URL;
            txtBoxInterfaceID.Text = Properties.Settings.Default.InterfaceID;
        }
    }
}
