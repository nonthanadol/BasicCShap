using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Prototype_App_PQM;

namespace Prototype_App
{
    public partial class MainForm : Form
    {
        //Declare class-level variable 

        private iVariableShare _Common;
        private clsPLC _clsPlc;
        private clsPQM _clsPQM;


        private uc_Home _home;
        private uc_PLCSetting _plcSetting;
        private uc_PQMSetting _pqmSetting;
        private Login _login;

        public MainForm()
        {
            InitializeComponent();

            //Create instance and Initializ

            _Common = new iVariableShare();


            _clsPlc = new clsPLC(_Common);
            _clsPQM = new clsPQM(_Common, Properties.Settings.Default.URL);

            _home = new uc_Home();
            _home.Dock = DockStyle.Fill;
            _home.Show();
            cotainerPanel.Controls.Add(_home);

            _plcSetting = new uc_PLCSetting(_Common);
            _plcSetting.Dock = DockStyle.Fill;
            _plcSetting.Hide();
            cotainerPanel.Controls.Add(_plcSetting);

            _pqmSetting = new uc_PQMSetting();
            _pqmSetting.Dock = DockStyle.Fill;
            _pqmSetting.Hide();
            cotainerPanel.Controls.Add(_pqmSetting);

            _login = new Login();
            _login.LoginSuccess += loging_succes;


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _clsPlc.connectPLC();
            _clsPlc.callReadStatusThread();

        }

        public void loging_succes(object sender, EventArgs e)
        {

            _plcSetting.Enable_textbox();
            _pqmSetting.Enable_textbox();
            Console.WriteLine("Method loging_succes");

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _pqmSetting.Hide();
            _plcSetting.Hide();
            _home.Show();

        }

        private void lbMonitorStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnPLCSetting_Click(object sender, EventArgs e)
        {
            _home.Hide();
            _pqmSetting.Hide();
            _plcSetting.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _clsPlc.disconnectPLC();

            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void btnPQMSetting_Click(object sender, EventArgs e)
        {
            _home.Hide();
            _plcSetting.Hide();
            _pqmSetting.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _login.ShowDialog();
        }

        private void UpdateUI_Tick(object sender, EventArgs e)
        {
            lbValuePLCconnect.Text = _Common.iPLCconnectStatus;
            lbValuePQMconnect.Text = _Common.iPQMconnectStatus;

            if (_Common.iPLCconnectStatus == "Connected")
            {
                lbValuePLCconnect.BackColor = Color.LightGreen;

                lbValueStatus.Text = Convert.ToString(_Common.iPQM_Status);
                lbValueStatusCode.Text = Convert.ToString(_Common.iPQM_Status_Code);
                lbValuePassQty.Text = Convert.ToString(_Common.iPQM_PassQty);
                lbValueFailQty.Text = Convert.ToString(_Common.iPQM_FailQty);
                lbValueErrCnt.Text = Convert.ToString(_Common.iPQM_Error_Count);
                lbValueSelfCheck.Text = Convert.ToString(_Common.iPQM_Self_Check);
                lbValueCycleTime.Text = Convert.ToString(_Common.iPQM_Cycle_Time);
                lbValueRunningTime.Text = Convert.ToString(_Common.iPQM_Running_Time);
                lbValueWaitingTime.Text = Convert.ToString(_Common.iPQM_Waiting_Time);
                lbValueErrTime.Text = Convert.ToString(_Common.iPQM_Error_Time);
                lbValueBarcode.Text = Convert.ToString(_Common.iPQM_Barcode);
            }
            else
            {
                lbValuePLCconnect.BackColor = Color.Red;

                lbValueStatus.Text = "Disconnect";
                lbValueStatusCode.Text = "Disconnect";
                lbValuePassQty.Text = "Disconnect";
                lbValueFailQty.Text = "Disconnect";
                lbValueErrCnt.Text = "Disconnect";
                lbValueSelfCheck.Text = "Disconnect";
                lbValueCycleTime.Text = "Disconnect";
                lbValueRunningTime.Text = "Disconnect";
                lbValueWaitingTime.Text = "Disconnect";
                lbValueErrTime.Text = "Disconnect";
                lbValueBarcode.Text = "Disconnect";
            }

            if (_Common.iPQMconnectStatus == "Connected")
            {
                lbValuePQMconnect.BackColor = Color.LightGreen;

            }
            else
            {
                lbValuePQMconnect.BackColor = Color.Red;
            }
        }

        private void UpdatePQM_Tick(object sender, EventArgs e)
        {

            _clsPQM.Send();

        }
    }
}
