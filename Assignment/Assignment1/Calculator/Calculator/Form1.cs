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

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox1_result.Text == "0" || (isOperationPerformed))
                textBox1_result.Clear();
            isOperationPerformed = false;
            Button button=(Button)sender;
            if(button.Text==".")
            {
                if(!textBox1_result.Text.Contains("."))
                
                    textBox1_result.Text = textBox1_result.Text + button.Text;
                
            }
            else

            textBox1_result.Text = textBox1_result.Text + button.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            if(resultValue!=0)
            {
                button34.PerformClick();
                Button button = (Button)sender;
                operationPerformed = button.Text;
                //resultValue = Double.Parse(textBox1_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                Button button = (Button)sender;
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
            resultValue = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1_result.Text = "0";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox1_result.Text = (resultValue + Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "-":
                    textBox1_result.Text = (resultValue - Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "*":
                    textBox1_result.Text = (resultValue * Double.Parse(textBox1_result.Text)).ToString();
                    break;
                case "/":
                    textBox1_result.Text = (resultValue / Double.Parse(textBox1_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox1_result.Text);
        }
    }
}
