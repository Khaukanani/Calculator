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

namespace Dimension_Calculator
{
    public partial class Form1 : Form
    {
        bool enter_value = false;
        string operation = "";
        double result = 0;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();

            t.Abort();
        }

        public void SplashStart()
        {
            Application.Run(new Splesh());
        }

        private void btn_Click(object sender, EventArgs e)//Works with all my number buttons including coma
        {
            Button b = (Button)sender;//My b variable get its value from the sender
            if ((txtDisplay.Text == "0") || (enter_value))
                //checks for string "0" on the screen
                txtDisplay.Text = "";//before we put any number on the screen we remove that "0"
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))//Now I'm working with repetetive comma problem
                    txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
            // txtDisplay.Text += b.Text;(This statement was a problem, My comma was assigned twice)

        }

        private void operators_Click(object sender, EventArgs e)//Works with all the operators
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                btnEql.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowUp.Text = result + "   " + operation;
            }
            else
            {
                operation = b.Text;
                result = double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowUp.Text = System.Convert.ToString(result) + "   " + operation;

            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            lblShowUp.Text = "";
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "x":
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    if (txtDisplay.Text == "0")
                    {
                        MessageBox.Show("Enter a valid number");
                    }
                    else
                    {
                        txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    }
                    
                    break;
                case "%":
                    //txtDisplay.Text = (double.Parse(txtDisplay.Text) /result ).ToString();

                    break;
                default:
                    break;
            }
            result = double.Parse(txtDisplay.Text);
            operation = "";
        }

        private void btnplsmins_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains('-'))
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Trim('-');
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void compoundInterestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();

        }

        private void massToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();

        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            this.Hide();

        }

        private void arraysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
            this.Hide();

        }

        private void currencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
