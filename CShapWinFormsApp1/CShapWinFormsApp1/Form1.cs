namespace CShapWinFormsApp1
{
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NonThanadol");
            btn2.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btn2.Visible = true;
        } */

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Offset data
            double xoffset;
            double yoffset;
            double theta_Deg;
            double.TryParse(textBox15.Text, out xoffset);
            double.TryParse(textBox14.Text, out yoffset);
            double.TryParse(textBox13.Text, out theta_Deg);

            // Recive Point1
            double xp1 = Convert.ToDouble(textBox1.Text);
            double yp1 = Convert.ToDouble(textBox2.Text);

            // Cal 
            double theta_Rad = theta_Deg* (Math.PI / 180);
            double xpp1 = (xp1 + xoffset)*Math.Sin(theta_Rad);  
            double ypp1 = yp1 + yoffset;

            textBox8.Text = Convert.ToString(xpp1);
            textBox7.Text = Convert.ToString(ypp1);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

    
 
    }
}