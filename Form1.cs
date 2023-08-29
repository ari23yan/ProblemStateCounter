using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProblemStateCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if(input.Length < 45  || string.IsNullOrEmpty(input))
            {
                label1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.BackColor = Color.White;
                label1.Text = "مقدار ورودی اشتباه می باشد";
            }
            else
            {
                List<string> termsList = new List<string>();

                if (int.Parse(input.Substring(0, 5)) != 0 || int.Parse(input.Substring(27, 7)) != 0)
                {
                    //techProblems = "آلایندگی" + " | ";
                    termsList.Add("آلایندگی");
                }
                if (int.Parse(input.Substring(5, 9)) != 0 || int.Parse(input.Substring(20, 2)) != 0)
                {
                    //techProblems += "ترمز" + " | ";
                    termsList.Add("ترمز");

                }
                if (int.Parse(input.Substring(14, 6)) != 0)
                {
                    //techProblems += "کمک فنر" + " | ";
                    termsList.Add("کمک فنر");
                }
                if (int.Parse(input.Substring(22, 2)) != 0)
                {
                    //techProblems += "لغزش جانبی" + " | ";
                    termsList.Add("لغزش جانبی");

                }
                if (int.Parse(input.Substring(35, 7)) != 0 || int.Parse(input.Substring(43, 3)) != 0)
                {
                    //techProblems += "ظاهری به جز صوت" + " | ";

                    termsList.Add("ظاهری به جز صوت");
                }
                if (int.Parse(input.Substring(42, 1)) != 0)
                {
                    //techProblems += "فقط صوت " + " | ";

                    termsList.Add("فقط صوت");
                }
                label2.Visible = true;
                label2.Font = new Font("SansSerif", 24, FontStyle.Bold);
                label2.ForeColor = Color.Green;
                label2.BackColor = Color.White;
                label2.Text =  termsList.Count().ToString();
                label1.Visible= true;
                label1.Font = new Font("IRANSans", 20, FontStyle.Bold);
                label1.Text = string.Join(" / ", termsList);


            }

           

        }
    }
}
