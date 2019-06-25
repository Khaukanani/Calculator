using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimension_Calculator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Int32 Ounce = System.Convert.ToInt32(txtResult.Text);

            double PounceConstant = 16;
            double gramConstant = 0.03527396194958;
            double kgConstace = 35.2739619;

            if (rdbPound.Checked)
            {
                textBox1.Text = System.Convert.ToString(Ounce * PounceConstant);
            }
            if (rdbKG.Checked)
            {
                textBox1.Text = System.Convert.ToString(Ounce * kgConstace);
            }
            if (rdbGrams.Checked)
            {
                textBox1.Text = System.Convert.ToString(Ounce * gramConstant);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void rdbGrams_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
