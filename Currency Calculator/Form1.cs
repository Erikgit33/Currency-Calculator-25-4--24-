using System.Diagnostics.Eventing.Reader;

namespace Currency_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        double dollars = 0;
        double euro = 0;
        double kronor = 0;
        double pounds = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                double.TryParse(textBox1.Text, out dollars);
                textBox2.Text = (dollars * 0.93).ToString("0.##");
                textBox3.Text = (dollars * 10.86).ToString("0.##");
                textBox4.Text = (dollars * 0.8).ToString("0.##");
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else if (i == 1) 
            {
                double.TryParse(textBox2.Text, out euro);
                textBox1.Text = (euro * 1.07).ToString("0.##");
                textBox3.Text = (euro * 11.64).ToString("0.##");
                textBox4.Text = (euro * 0.86).ToString("0.##");
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else if (i == 2)
            {
                double.TryParse(textBox3.Text, out kronor);
                textBox1.Text = (kronor * 0.092).ToString("0.##");
                textBox2.Text = (kronor * 0.086).ToString("0.##");
                textBox4.Text = (kronor * 0.074).ToString("0.##");
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else if (i == 3)
            {
                double.TryParse(textBox4.Text, out pounds);
                textBox1.Text = (pounds * 1.25).ToString("0.##");
                textBox2.Text = (pounds * 1.17).ToString("0.##");
                textBox3.Text = (pounds * 13.59).ToString("0.##");
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            i = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            i = 1;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            i = 2;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            i = 3;
        }
    }
}
