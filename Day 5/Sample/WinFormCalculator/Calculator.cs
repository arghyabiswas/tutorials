using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Sample
{
    public partial class Calculator : Form
    {
        delegate double ExecuteOperation(double x, double y);
        double previousNumber = 0;
        bool isDot = false;
        ExecuteOperation executeOperation;
        public Calculator()
        {
            InitializeComponent();
        }

        

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button source = (Button)sender;

            double inputNumber = 0;
            if (!string.IsNullOrEmpty(textBox_Result.Text))
            {
                inputNumber = Convert.ToDouble(textBox_Result.Text);
            }
            if (!isDot)
            {
                inputNumber = 10 * inputNumber + Convert.ToDouble(source.Text);
            }
            else
            {

            }

            if (inputNumber < 1000000000000)
            {
                textBox_Result.Text = inputNumber.ToString();
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button source = (Button)sender;

            isDot = false;
            switch (source.Text)
            {
                case "+":
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = "0";
                    executeOperation = new ExecuteOperation(Add);
                    break;
                case "-":
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = "0";
                    executeOperation = new ExecuteOperation(Substract);
                    break;
                case "*":
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = "0";
                    executeOperation = new ExecuteOperation(Multiply);
                    break;
                case "/":
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = "0";
                    executeOperation = new ExecuteOperation(Devide);
                    break;
                case "=":
                default:
                    if(executeOperation != null)
                    {
                        double nextNumber = Convert.ToDouble(textBox_Result.Text);
                        previousNumber = executeOperation.Invoke(previousNumber, nextNumber);
                        textBox_Result.Text = previousNumber.ToString();
                        previousNumber = 0;
                    }
                    break;
            }
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            double inputNumber = 0;
            if (!string.IsNullOrEmpty(textBox_Result.Text))
            {
                inputNumber = Convert.ToDouble(textBox_Result.Text);
            }
            

            isDot = true;
        }

       
        private double Add(double x,double y)
        {
            return x + y;
        }

        private double Substract(double x, double y)
        {
            return x - y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Devide(double x, double y)
        {
            if (y == 0)
            {
                return 0;
            }
            return x / y;
        }
    }
}
