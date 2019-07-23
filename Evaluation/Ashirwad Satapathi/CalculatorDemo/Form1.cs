using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDemo
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        //This method is responsible for intializing the inputs as operands and use it later
        private void button_click(object sender, EventArgs e)
        {
            if (result.Text == "0" || (operation_pressed)) {
                result.Text = "";
            }
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        // This method stores the operator clicked and sets a flag that a operator was clicked 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
        }

        //This method performs the calculation and is called when the = button is clicked
        private void equals(object sender, EventArgs e)
        {
            switch (operation) {

                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }// end switch
            operation_pressed = false;
        }
    }
}
