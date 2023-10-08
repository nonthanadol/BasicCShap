using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Prototype_App
{
    public partial class uc_PLCSetting : UserControl
    {
        private clsPLC _clsPlc;
        iVariableShare _Common = new iVariableShare();

        public uc_PLCSetting(iVariableShare common)
        {
            InitializeComponent();

            _Common = common;       
            _clsPlc = new clsPLC(_Common);

           
        }

        private void uc_PLCSetting_Load(object sender, EventArgs e)
        {
            txtBoxIPAddress.Text = Properties.Settings.Default.IPAddress;
            txtBoxDstatus.Text = Properties.Settings.Default.Dstatus;
            txtBoxDstatusCode.Text = Properties.Settings.Default.DstatusCode;
            txtBoxDpassQty.Text = Properties.Settings.Default.DpassQty;
            txtBoxDfailQty.Text = Properties.Settings.Default.DfailQty;
            txtBoxDerrCnt.Text = Properties.Settings.Default.DfailQty;
            txtBoxDselfCheck.Text = Properties.Settings.Default.DselfCheck;
            txtBoxDcycleTime.Text = Properties.Settings.Default.DcycleTime;
            txtBoxDrunningTime.Text = Properties.Settings.Default.DrunningTime;
            txtBoxDwaitingTime.Text = Properties.Settings.Default.DwaitingTime;
            txtBoxDerrTime.Text = Properties.Settings.Default.DerrTime;
            txtBoxDbarcode.Text = Properties.Settings.Default.Dbarcode;
        }

        

        public void Enable_textbox() 
        {
            txtBoxIPAddress.Enabled = true;
            txtBoxDstatus.Enabled = true;
            txtBoxDstatusCode.Enabled = true;
            txtBoxDpassQty.Enabled = true;
            txtBoxDfailQty.Enabled = true;
            txtBoxDerrCnt.Enabled = true;
            txtBoxDselfCheck.Enabled = true;
            txtBoxDcycleTime.Enabled = true;
            txtBoxDrunningTime.Enabled = true;
            txtBoxDwaitingTime.Enabled = true;
            txtBoxDerrTime.Enabled = true;
            txtBoxDbarcode.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _clsPlc.connectPLC();
            _clsPlc.callReadStatusThread();


        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _clsPlc.disconnectPLC();
            _clsPlc.StopReadStatusThread();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbDfailQty_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPAddress = txtBoxIPAddress.Text;
            Properties.Settings.Default.Dstatus = txtBoxDstatus.Text;
            Properties.Settings.Default.DstatusCode = txtBoxDstatusCode.Text;
            Properties.Settings.Default.DpassQty = txtBoxDpassQty.Text;
            Properties.Settings.Default.DfailQty = txtBoxDfailQty.Text;
            Properties.Settings.Default.DerrorCnt = txtBoxDerrCnt.Text;
            Properties.Settings.Default.DselfCheck = txtBoxDselfCheck.Text;
            Properties.Settings.Default.DcycleTime = txtBoxDcycleTime.Text;
            Properties.Settings.Default.DrunningTime = txtBoxDrunningTime.Text;
            Properties.Settings.Default.DwaitingTime = txtBoxDwaitingTime.Text;
            Properties.Settings.Default.DerrTime = txtBoxDerrTime.Text;
            Properties.Settings.Default.Dbarcode = txtBoxDbarcode.Text;

            Properties.Settings.Default.Save();
        }

        private void lbLoad_Click(object sender, EventArgs e)
        {
            txtBoxIPAddress.Text = Properties.Settings.Default.IPAddress;
            txtBoxDstatus.Text = Properties.Settings.Default.Dstatus;
            txtBoxDstatusCode.Text = Properties.Settings.Default.DstatusCode;
            txtBoxDpassQty.Text = Properties.Settings.Default.DpassQty;
            txtBoxDfailQty.Text = Properties.Settings.Default.DfailQty;
            txtBoxDerrCnt.Text = Properties.Settings.Default.DfailQty;
            txtBoxDselfCheck.Text = Properties.Settings.Default.DselfCheck;
            txtBoxDcycleTime.Text = Properties.Settings.Default.DcycleTime;
            txtBoxDrunningTime.Text = Properties.Settings.Default.DrunningTime;
            txtBoxDwaitingTime.Text = Properties.Settings.Default.DwaitingTime;
            txtBoxDerrTime.Text = Properties.Settings.Default.DerrTime;
            txtBoxDbarcode.Text = Properties.Settings.Default.Dbarcode;

        }
    }
}
