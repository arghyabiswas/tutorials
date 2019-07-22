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
    public partial class CalculatorForm : Form
    {
        bool isOperationPerformed = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operator_click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }
        private void operator_click(object sender, EventArgs e)
        {
            if (output.Text.ToString() == "0")
            {
                output.Text = "0";
            }
            else
            {
                Button button = (Button)sender;
                string data = output.Text;
                string str = data.Substring(data.Length - 1);
                if (str == "+" || str == "-" || str == "*" || str == "/")
                {
                    output.Text = data.Substring(0, data.Length - 1);
                }
                button_Click(sender, e);
            }


        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (output.Text == "0")
            {
                output.Clear();
            }
            output.Text = output.Text + button.Text;
        }


        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            try
            {
                var result = data.Compute(output.Text.ToString(), "");
                output.Text = Convert.ToString(result);
            }
            catch
            {
                output.Text = "0";
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            operator_click(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operator_click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operator_click(sender, e);
        }
    }
}
