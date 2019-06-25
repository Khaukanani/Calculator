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
    public partial class Form6 : Form
    {
        Double Nigerian_Naira = 302.96;
        Double US_Dollar = 1.52;
        Double Kenyan_Shilling = 156.21;
        Double Brazilian_Real = 5.86;
        Double Canadian_Dollar = 2.03;
        Double Indian_Rupee = 100.68;
        Double Philippine_Peso = 71.74;
        Double Indonesian_Rupiah = 20746.75;
        public Form6()
        {
            InitializeComponent();
        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
            cmbCurrency.Text = "Choose One......";
            cmbCurrency.Items.Add("USA");
            cmbCurrency.Items.Add("Nigeria");
            cmbCurrency.Items.Add("Kenyan");
            cmbCurrency.Items.Add("Canada");
            cmbCurrency.Items.Add("Brazil");
            cmbCurrency.Items.Add("India");
            cmbCurrency.Items.Add("Philippine");
            cmbCurrency.Items.Add("Indonesia");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            txtConvert.Clear();
            lblConvert.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Double British_Pound = Double.Parse(txtConvert.Text);
            if(cmbCurrency.Text == "Nigeria")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is " + British_Pound * Nigerian_Naira+ " Naira"));
            }
            if (cmbCurrency.Text == "Kenyan")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is" + British_Pound * Kenyan_Shilling+ " Shilling"));
            }
            if (cmbCurrency.Text == "USA")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is " + British_Pound * US_Dollar+ " $"));
            }
            if (cmbCurrency.Text == "Canada")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is " + British_Pound * Canadian_Dollar+ " Canadian Dollar"));
            }
            if (cmbCurrency.Text == "Brazil")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is " + British_Pound * Brazilian_Real+" Reals"));
            }
            if (cmbCurrency.Text == "India")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is  " + British_Pound * Indian_Rupee+" Rupee"));
            }
            if (cmbCurrency.Text == "Philippine")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is " + British_Pound * Philippine_Peso + " Peso"));
            }
            if (cmbCurrency.Text == "Indonesia")
            {
                lblConvert.Text = System.Convert.ToString(("Pound is " + British_Pound * Indonesian_Rupiah + " Rupiah "));
            }

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
