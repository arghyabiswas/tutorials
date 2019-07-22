using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASP.NET_Trainning
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            result.Text = "";
        }
        double num1, num2;
        bool plusb=false, minusb=false, divideb=false, multiplyb=false;
        
        private void Button14_Click(object sender, EventArgs e)
        {
            multiplyb = true;
            num1 = Convert.ToDouble(result.Text);
            result.Text = "";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            result.Text += "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            result.Text += "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            result.Text += "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            result.Text += "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            result.Text += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            result.Text += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            result.Text += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            result.Text += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            result.Text += "9";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            string b = result.Text;
            char[] c = b.ToCharArray();
            int flag = 0;
            for(int i=0;i<c.Length;i++)
            {
                if (c[i] == '.')
                    flag++;
            }
            if (flag == 0)
                result.Text += ".";
            else
                result.Text = "Invalid input !";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            result.Text += "0";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(result.Text);
            result.Text = "";
            if(plusb==true)
            {
                result.Text = (num1 + num2).ToString();
            }
            if (minusb == true)
            {
                result.Text = (num1 - num2).ToString();
            }
            if (multiplyb == true)
            {
                result.Text = (num1 * num2).ToString();
            }
            if (divideb == true)
            {
                result.Text = (num1 / num2).ToString();
            }
            plusb = minusb = divideb = multiplyb = false;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            plusb = true;
            num1 = Convert.ToDouble(result.Text);
            result.Text = "";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            minusb = true;
            num1 = Convert.ToDouble(result.Text);
            result.Text = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            divideb = true;
            num1 = Convert.ToDouble(result.Text);
            result.Text = "";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            result.Text = "";
        }
    }
}
