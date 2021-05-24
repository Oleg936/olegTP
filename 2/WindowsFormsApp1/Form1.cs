using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Makeit_Click(object sender, EventArgs e)
        {
            int k = 2;
            Double Zoo = 0;
            int n = Convert.ToInt32(N.Text);
            int r = Convert.ToInt32(R.SelectedItem.ToString());
            Double p = Convert.ToDouble(P.Text);
            int d = Convert.ToInt32(D.SelectedItem.ToString());
            Double c = Convert.ToDouble(C.Text);

            if (equation1.Checked)
            {
                for (int i =0; i<n; i++)
                {
                    if (i%2 == 0)
                    {
                        Zoo += -1.00d*((Math.Pow(p, i+2)) / ((i+1)*k));
                        k *= i + 3;
                    }
                    else
                    {
                        Zoo+= 1.00d * ((Math.Pow(p, i + 2)) / ((i + 1) * k));
                        k *= i + 3;
                    }
                }
            }
            else if (equation2.Checked)
            {
                Zoo = 0;
                for (int i=0; i<n; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        Zoo= Zoo +1.00d*((Math.Pow(i+1, 2) + d * (j+1)) / (Math.Pow(c,i+1)*Math.Pow(i+1,3)));
                    }
                }
                
            }
            
            Answer.Text = Zoo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
