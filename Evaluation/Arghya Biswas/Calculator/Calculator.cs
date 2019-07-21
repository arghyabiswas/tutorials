using System;
using System.Windows.Forms;

namespace Tutorial
{
    /// <summary>
    /// Calculator Forms
    /// </summary>
    public partial class Calculator : Form
    {
        #region Variables
        delegate double ExecuteOperation(double x, double y);
        double previousNumber = 0;
        ExecuteOperation executeOperation;
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor of Calculator
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
        }
        #endregion

        #region Button Events
        /// <summary>
        /// Click Event for Numeric number buttons
        /// </summary>
        /// <param name="sender">Numeric Buttons</param>
        /// <param name="e">Event Argument</param>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            // Input Validation:
            if (textBox_Result.Text.Length >= 12)
            {
                return;
            }

            // Identifying the source button
            Button source = (Button)sender;

            if (textBox_Result.Text.StartsWith("0")
                && !textBox_Result.Text.Contains(".")
                && !source.Text.Equals("0"))
            {
                textBox_Result.Text = string.Empty;
            }



            //Concatenating digits
            textBox_Result.Text = string.Format("{0}{1}", textBox_Result.Text, source.Text);
        }

        /// <summary>
        /// Click Event for Operational Buttons
        /// </summary>
        /// <param name="sender">Operational Buttons</param>
        /// <param name="e">Event Argument</param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            // Identifying the source button
            Button source = (Button)sender;

            switch (source.Text)
            {
                case "+":
                    // Creating delegate for Add Operation
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = string.Empty;
                    executeOperation = new ExecuteOperation(Add);
                    break;
                case "-":

                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = string.Empty;
                    // Creating delegate for Subtract Operation
                    executeOperation = new ExecuteOperation(Subtract);
                    break;
                case "*":
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = string.Empty;
                    // Creating delegate for Multiply Operation
                    executeOperation = new ExecuteOperation(Multiply);
                    break;
                case "/":
                    previousNumber = Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = string.Empty;
                    // Creating delegate for Divide Operation
                    executeOperation = new ExecuteOperation(Divide);
                    break;
                case "=":
                default:
                    if (executeOperation != null)
                    {
                        double nextNumber = Convert.ToDouble(textBox_Result.Text);
                        // Exception handling
                        try
                        {
                            previousNumber = executeOperation.Invoke(previousNumber, nextNumber);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(this, ex.Message, "Error in Calculator");
                        }
                        finally
                        {
                            textBox_Result.Text = previousNumber.ToString();
                            previousNumber = 0;
                        }
                        
                    }
                    break;
            }
        }

        /// <summary>
        /// Click Event for Operational Buttons
        /// </summary>
        /// <param name="sender">Dot Buttons</param>
        /// <param name="e">Event Argument</param>
        private void button_dot_Click(object sender, EventArgs e)
        {


            // Input Validation:
            if (textBox_Result.Text.Length >= 12)
            {
                return;
            }

            // Validating if text box already have a dot(.)
            if (textBox_Result.Text.Contains("."))
            {
                return;
            }

            // Input Validation: empty string
            if (string.IsNullOrEmpty(textBox_Result.Text))
            {
                textBox_Result.Text = "0";
            }

            //Concatenating dots
            textBox_Result.Text = string.Format("{0}.", textBox_Result.Text);
        }

        #endregion

        #region Functional Area

        /// <summary>
        /// Addition of two numeric value
        /// </summary>
        /// <param name="x">First parameter</param>
        /// <param name="y">Second parameter</param>
        /// <returns>Sum of two number</returns>
        private double Add(double x, double y)
        {
            try
            {
                return x + y;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Subtraction of two numeric value
        /// </summary>
        /// <param name="x">First parameter</param>
        /// <param name="y">Second parameter</param>
        /// <returns>Subtraction of second number from the first</returns>
        private double Subtract(double x, double y)
        {
            try
            {
                return x - y;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Multiplication of two number
        /// </summary>
        /// <param name="x">First parameter</param>
        /// <param name="y">Second parameter</param>
        /// <returns>Multiplication of two number</returns>
        private double Multiply(double x, double y)
        {
            try
            {
                return x * y;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Division of two number
        /// </summary>
        /// <param name="x">First parameter</param>
        /// <param name="y">Second parameter</param>
        /// <returns>Divide first number by the second number; throws if second number id zero</returns>
        private double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Value can not be zero.", "y");
            }

            try
            {
                return x / y;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
