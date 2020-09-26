using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUISeriesParallel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog(); 
        }

        private void btnRp_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();

        }

        private void btnCs_Click(object sender, EventArgs e)
        {
            Form f4= new Form4();
            f4.ShowDialog();

        }

        private void btnCp_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.ShowDialog();

        }

        private void btnLs_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.ShowDialog();

        }

        private void btnLp_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7();
            f7.ShowDialog();

        }
    }
}
