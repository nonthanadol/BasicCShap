using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_ModbusTCP_DeltaPLC
{
    public partial class UserControl2 : UserControl
    {
        //UserControl1 obj_uc1 = new UserControl1();
        
        public UserControl2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //M0 = 2049
            UserControl1.uc1.obj_modbus.WriteSingleCoil(2049, checkBox1.Checked);// ModbusAddress,Value
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //M0 = 2050
            //obj_uc1.obj_modbus.WriteSingleCoil(2050, checkBox2.Checked);// ModbusAddress,Value
            UserControl1.uc1.obj_modbus.WriteSingleCoil(2050, checkBox2.Checked);// ModbusAddress,Value
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Y0 = 1281
            //obj_uc1.obj_modbus.WriteSingleCoil(1281, checkBox3.Checked);// ModbusAddress,Value
            UserControl1.uc1.obj_modbus.WriteSingleCoil(1281, checkBox3.Checked);// ModbusAddress,Value
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Y1 = 1282
            //obj_uc1.obj_modbus.WriteSingleCoil(1282, checkBox4.Checked); // ModbusAddress,Value
            UserControl1.uc1.obj_modbus.WriteSingleCoil(1282, checkBox4.Checked);// ModbusAddress,Value
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Write D0 = 404097
           // obj_uc1.obj_modbus.WriteSingleRegister(404097, Convert.ToInt32(textBox3.Text)); // ModbusAddress,Value
            //obj_uc1.obj_modbus.WriteSingleRegister(404098, Convert.ToInt32(textBox4.Text));

            UserControl1.uc1.obj_modbus.WriteSingleRegister(4097, Convert.ToInt32(textBox3.Text)); // ModbusAddress,Value
            UserControl1.uc1.obj_modbus.WriteSingleRegister(4098, Convert.ToInt32(textBox4.Text)); // ModbusAddress,Value
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] D = UserControl1.uc1.obj_modbus.ReadHoldingRegisters(4097, 2);
            textBox5.Text = Convert.ToString(D[0]);
            textBox6.Text = Convert.ToString(D[1]);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
