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
    public partial class Form6 : Form
    {
        private int n;
        double value1;
        double sum = 0;
        private string a, l;
        public Form6()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(n);
            int txtno = n;
            int pointX = 180;
            int pointY = 30;
            int pointX1 = 30;
            int pointY1 = 30;
            panel2.Controls.Clear();
            for (int i = 0; i < txtno; i++)
            {
                Label l = new Label();
                TextBox a = new TextBox();
                l.Text = "Enter value of L" + (i + 1).ToString();
                l.Location = new Point(pointX1, pointY1);
                l.Size = new Size(200, 20);
                l.AutoSize = true;
                l.Font = new Font("Arial", 10, FontStyle.Regular);
                //a.Text = "Enter R"+(i+1).ToString();
                a.Location = new Point(pointX, pointY);
                a.Size = new Size(200, 20);
                a.AutoSize = true;
                a.Font = new Font("Arial", 10, FontStyle.Regular);
                panel2.Controls.Add(l);
                panel2.Controls.Add(a);
                panel2.Show();
                pointY += 30;
                pointY1 += 30;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in panel2.Controls)
            {
                if (ctr is TextBox)
                {
                    string value = ((TextBox)ctr).Text;
                    value1 = Convert.ToDouble(value);
                    sum = value1 + sum;

                }
                panel3.Controls.Clear();
                Label Label1 = new Label();
                Label1.Text = "The Leq is : " + sum.ToString();
                Label1.Location = new Point(80, 30);
                Label1.Size = new Size(200, 20);
                Label1.AutoSize = true;
                Label1.Font = new Font("Arial", 10, FontStyle.Regular);
                panel3.Controls.Add(Label1);
                panel3.Show();

            }

        }


    }
}
