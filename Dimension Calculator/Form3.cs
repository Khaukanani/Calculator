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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            double principle = double.Parse(txtPrinciple.Text);
            double interestRate = double.Parse(txtInterestRate.Text);
            int numYears = int.Parse(txtNumYears.Text);
            for (int i = 1; i <= numYears; i++)
            {
                double balance = principle * Math.Pow(1 + interestRate, i);
                lstResults.Items.Add("Year " + i.ToString() + "\t" + "R"+
                    balance.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
