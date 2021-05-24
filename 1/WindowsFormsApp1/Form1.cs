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
        double a, b, c, ans;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ans = 1.00d * ((Math.Pow(a, 3) - e.X + Math.Abs(Math.Cos(e.Y) + Math.Abs(b))) / (c * Math.Tan(b)));

            if (ans-ans == 0)
            {
                Text = ans.ToString();
                U.ReadOnly = true;
                U.Text = Text.ToString();

            }
            else
                Text = "Error";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { 
   
            a = Convert.ToDouble(v.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            {
                c = Convert.ToDouble(A_del.Text);
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(t.Text);
        }
    }
}
