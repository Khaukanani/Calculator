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
    public partial class Splesh : Form
    {
        public Splesh()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(25);
            if (progressBar1.Value == 100)
                timer1.Stop();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
