using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemStateCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if(input.Length < 45  || string.IsNullOrEmpty(input))
            {
                label1.ForeColor = Color.Red;
                label1.BackColor = Color.White;
                label1.Text = "مقدار ورودی اشتباه می باشد";
            }
            else
            {
                var problemStateCount = 0;
                if(int.Parse(input.Substring(0,5)) != 0)
                {
                    problemStateCount++; // alayandegi
                }
                if (int.Parse(input.Substring(5,9 )) != 0 || int.Parse(input.Substring(20, 2)) != 0)
                {
                    problemStateCount++; // tormoz
                }
                if (int.Parse(input.Substring(14, 6)) != 0)
                {
                    problemStateCount++; // komak fanar
                }
                if (int.Parse(input.Substring(22, 2)) != 0)
                {
                    problemStateCount++; // laghzesh
                }
                if (int.Parse(input.Substring(22, 2)) != 0)
                {
                    problemStateCount++; // laghzesh
                }


            }

           

        }
    }
}
