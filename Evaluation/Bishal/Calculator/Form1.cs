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
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonclick(object sender, EventArgs e)
        {
            
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox__result.Text == "0") || (isOperationPerformed))
                textBox__result.Clear();
             isOperationPerformed = false;

            Button button = (Button)sender;
            if(button.Text==".")
            {
                if (!textBox__result.Text.Contains("."))
                    textBox__result.Text = textBox__result.Text + button.Text;
            }
            else

            textBox__result.Text = textBox__result.Text + button.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button12.PerformClick();
                operationPerformed = button.Text;
                label_current_operation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else

            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox__result.Text);
                label_current_operation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox__result.Text = "0";
            resultValue = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox__result.Text = (resultValue + Double.Parse(textBox__result.Text)).ToString();
                    break;
                case "-":
                    textBox__result.Text = (resultValue - Double.Parse(textBox__result.Text)).ToString();
                    break;
                case "*":
                    textBox__result.Text = (resultValue * Double.Parse(textBox__result.Text)).ToString();
                    break;
                case "/":
                    textBox__result.Text = (resultValue / Double.Parse(textBox__result.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(textBox__result.Text);
            label_current_operation.Text = " ";
        }
    }
}
