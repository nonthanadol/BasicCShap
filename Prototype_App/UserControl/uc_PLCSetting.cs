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
        private iVariableShare _Common;
      
        public uc_PLCSetting()
        {
            InitializeComponent();

            _Common = new iVariableShare();         
            _clsPlc = new clsPLC(_Common);

           
        }

        private void uc_PLCSetting_Load(object sender, EventArgs e)
        {

        }

        

        public void Enable_textbox() 
        {
        
        
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _clsPlc.connectPLC();
            _clsPlc.callReadStatusThread();


        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _clsPlc.disconnectPLC();
            
        }
    }
}
