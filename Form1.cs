using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoping_Cart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label8.Text="$"+(int.Parse(textBox1.Text)*9.95).ToString();
            }
            else
            {
                label8.Text = "";
            }
            total();

        }
        private void total()
        {
            float total=0;
            if (label8.Text != "")
            {
                string a="";
                for(int i = 1; i < label8.Text.Length; i++)
                {
                    a+=label8.Text[i];
                }
                total += float.Parse(a);
            }
          
            if (label9.Text != "")
            {
                string a = "";
                for (int i = 1; i < label9.Text.Length; i++)
                {
                    a += label9.Text[i];
                }
                total += float.Parse(a);
            }
           
            if (label10.Text != "")
            {
                string a = "";
                for (int i = 1; i < label10.Text.Length; i++)
                {
                    a += label10.Text[i];
                }
                total += float.Parse(a);
            }
            
            label11.Text = "Total : $ "+ total.ToString();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
            {
                label9.Text = "$" + (int.Parse(textBox2.Text) * 19.95).ToString();

            }
            else
            {
                label9.Text = "";
            }
                total();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text != "")
            {
                label10.Text = "$" + (int.Parse(textBox3.Text) * 14.95).ToString();
            }
            else
            {
                label10.Text = "";
            }
                total();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
