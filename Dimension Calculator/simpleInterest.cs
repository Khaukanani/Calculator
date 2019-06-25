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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal p = Convert.ToDecimal(this.txtPrinciple.Text);
            Decimal r = Convert.ToDecimal(this.txtRate.Text);
            Decimal t = Convert.ToDecimal(this.txtDuration.Text);
            Decimal i = (p * r * t) / 100;
            Decimal fv = (p + i);
            this.txtInterest.Text = ("R"+i.ToString());
            this.txtFv.Text = ("R" +fv.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
