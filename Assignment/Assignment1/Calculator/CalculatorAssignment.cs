using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorAssignment : Form
    {
        public CalculatorAssignment()
        {
            InitializeComponent();
            tb1.Text = "";
        }
        bool plusbuttonclicked = false, minusbuttonclicked = false, dividebuttonclicked = false, multiplybuttonclicked = false;
        double num1, num2;
        private void Button1_Click(object sender, EventArgs e)
        {
            tb1.Text+= "1";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + "2";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tb1.Text += "3";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tb1.Text += "4";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tb1.Text += "5";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            tb1.Text += "6";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tb1.Text += "7";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tb1.Text += "8";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            tb1.Text += "9";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string b = tb1.Text.ToString();
            char[] a = b.ToCharArray();
            int flag = 0;
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == '.')
                    flag++;

            }
            if (flag == 0)
                tb1.Text += ".";
            else
                tb1.Text = "invalid input";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tb1.Text += "0";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
            if(plusbuttonclicked==true)
            {
                tb1.Text = Convert.ToString(num1 + num2);
            }
            if(minusbuttonclicked==true)
            {
                tb1.Text = Convert.ToString(num1 - num2);
            }
           if(multiplybuttonclicked==true)
            {
                tb1.Text = Convert.ToString(num1 * num2);
            }
           if(dividebuttonclicked==true)
            {
                tb1.Text = Convert.ToString(num1 / num2);
            }

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            plusbuttonclicked = true;
            num1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            minusbuttonclicked = true;
            num1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            dividebuttonclicked = true;
            num1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            multiplybuttonclicked = true;
            num1 = Convert.ToDouble(tb1.Text);
            tb1.Text = "";
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
        }
    }
}
