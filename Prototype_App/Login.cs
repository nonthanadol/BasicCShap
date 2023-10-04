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
    public partial class Login : Form
    {
        public event EventHandler LoginSuccess;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = "11";
            string pass = "11";

            if (txtBoxID.Text == id && txtBoxPassword.Text == pass)
            {
                MessageBox.Show("Login Success");

                LoginSuccess?.Invoke(this, EventArgs.Empty);

                this.Close();

            }
            else
            {
                MessageBox.Show("id or password incorrect");
            }
        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }
    }
}
