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
    public partial class Calculator : Form
    {


        public Calculator()
        {
            InitializeComponent();
        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }



        private void Calculator_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanelButton_Paint(object sender, PaintEventArgs e)
        {

        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMOD = new System.Windows.Forms.Button();
            this.buttonPercentage = new System.Windows.Forms.Button();
            this.buttonClearElement = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.textBoxResult, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelButton, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.58824F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.41177F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(595, 405);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(10, 10);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(575, 63);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "0";
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged_1);
            // 
            // tableLayoutPanelButton
            // 
            this.tableLayoutPanelButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanelButton.ColumnCount = 6;
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.Controls.Add(this.button2, 2, 6);
            this.tableLayoutPanelButton.Controls.Add(this.button3, 3, 6);
            this.tableLayoutPanelButton.Controls.Add(this.button4, 1, 5);
            this.tableLayoutPanelButton.Controls.Add(this.button5, 2, 5);
            this.tableLayoutPanelButton.Controls.Add(this.button6, 3, 5);
            this.tableLayoutPanelButton.Controls.Add(this.button0, 2, 7);
            this.tableLayoutPanelButton.Controls.Add(this.button7, 1, 4);
            this.tableLayoutPanelButton.Controls.Add(this.button8, 2, 4);
            this.tableLayoutPanelButton.Controls.Add(this.button9, 3, 4);
            this.tableLayoutPanelButton.Controls.Add(this.buttonDot, 1, 7);
            this.tableLayoutPanelButton.Controls.Add(this.buttonEqual, 3, 7);
            this.tableLayoutPanelButton.Controls.Add(this.buttonAdd, 4, 4);
            this.tableLayoutPanelButton.Controls.Add(this.buttonSubstract, 4, 5);
            this.tableLayoutPanelButton.Controls.Add(this.buttonMultiply, 4, 6);
            this.tableLayoutPanelButton.Controls.Add(this.buttonDivision, 4, 7);
            this.tableLayoutPanelButton.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanelButton.Controls.Add(this.buttonMOD, 1, 3);
            this.tableLayoutPanelButton.Controls.Add(this.buttonPercentage, 2, 3);
            this.tableLayoutPanelButton.Controls.Add(this.buttonClearElement, 3, 3);
            this.tableLayoutPanelButton.Controls.Add(this.buttonClear, 4, 3);
            this.tableLayoutPanelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButton.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelButton.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            this.tableLayoutPanelButton.RowCount = 9;
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelButton.Size = new System.Drawing.Size(589, 316);
            this.tableLayoutPanelButton.TabIndex = 1;
            this.tableLayoutPanelButton.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelButton_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(199, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(297, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(101, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(199, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(297, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(199, 211);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(92, 46);
            this.button0.TabIndex = 6;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(101, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 46);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(199, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 46);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(297, 55);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 46);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDot.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(101, 211);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.buttonDot.Size = new System.Drawing.Size(92, 46);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.Location = new System.Drawing.Point(297, 211);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(92, 46);
            this.buttonEqual.TabIndex = 11;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(395, 55);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 46);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubstract.Location = new System.Drawing.Point(395, 107);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(92, 46);
            this.buttonSubstract.TabIndex = 13;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = true;
            this.buttonSubstract.Click += new System.EventHandler(this.buttonSubstract_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiply.Location = new System.Drawing.Point(395, 159);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(92, 46);
            this.buttonMultiply.TabIndex = 14;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivision.Location = new System.Drawing.Point(395, 211);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(92, 46);
            this.buttonDivision.TabIndex = 15;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(101, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMOD
            // 
            this.buttonMOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMOD.Location = new System.Drawing.Point(101, 3);
            this.buttonMOD.Name = "buttonMOD";
            this.buttonMOD.Size = new System.Drawing.Size(92, 46);
            this.buttonMOD.TabIndex = 17;
            this.buttonMOD.Text = "MOD";
            this.buttonMOD.UseVisualStyleBackColor = true;
            this.buttonMOD.Click += new System.EventHandler(this.buttonMOD_Click);
            // 
            // buttonPercentage
            // 
            this.buttonPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPercentage.Location = new System.Drawing.Point(199, 3);
            this.buttonPercentage.Name = "buttonPercentage";
            this.buttonPercentage.Size = new System.Drawing.Size(92, 46);
            this.buttonPercentage.TabIndex = 18;
            this.buttonPercentage.Text = "%";
            this.buttonPercentage.UseVisualStyleBackColor = true;
            this.buttonPercentage.Click += new System.EventHandler(this.buttonPercentage_Click);
            // 
            // buttonClearElement
            // 
            this.buttonClearElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearElement.Location = new System.Drawing.Point(297, 3);
            this.buttonClearElement.Name = "buttonClearElement";
            this.buttonClearElement.Size = new System.Drawing.Size(92, 46);
            this.buttonClearElement.TabIndex = 19;
            this.buttonClearElement.Text = "CE";
            this.buttonClearElement.UseVisualStyleBackColor = true;
            this.buttonClearElement.Click += new System.EventHandler(this.buttonClearElement_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.Location = new System.Drawing.Point(395, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(92, 46);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(595, 405);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load_1);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        /// <summary>
        /// Fuction to hanlde the Operators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void operatorClick(object sender, EventArgs e)
        {
            if (textBoxResult.Text.ToString() == "0")
            {
                textBoxResult.Text = "0";
            }
            else
            {
                Button button = (Button)sender;
                string data = textBoxResult.Text;
                string str = data.Substring(data.Length - 1);
                if (str == "+"|| str == "-" || str == "*" || str == "/")
                {
                    textBoxResult.Text = data.Substring(0, data.Length - 1);
                }
                buttonClick(sender, e);
            }


        }



        /// <summary>
        /// Concat Result for the Text box for each button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Clear();
            }
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }
        /// <summary>
        /// Button 1 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button 2 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button 3 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button 4 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button 5 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }


        /// <summary>
        /// Button 6 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button6_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }
        /// <summary>
        /// Button 7 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button7_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button 8 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button8_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }
        /// <summary>
        /// Button 9 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button 0 Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button0_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }
        /// <summary>
        /// Button Dot Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDot_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        /// <summary>
        /// Button Add Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operatorClick(sender, e);
            
        }
        /// <summary>
        /// Button Substract Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            operatorClick(sender, e);
        }
        /// <summary>
        /// Button Multiply Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operatorClick(sender, e);
        }

        /// <summary>
        /// Button Division Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonDivision_Click(object sender, EventArgs e)
        {

            operatorClick(sender, e);
        }

        /// <summary>
        /// Button Equal Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            try
            {
                var result = data.Compute(textBoxResult.Text.ToString(), "");
                textBoxResult.Text = Convert.ToString(result);
            }
            catch
            {
                textBoxResult.Text = "0";
            }

        }
        /// <summary>
        /// Clear the Result field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }
        /// <summary>
        /// Delete one charecter from right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonClearElement_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == string.Empty)
            {
                textBoxResult.Text = "0";
            }
            else
            {
                if (textBoxResult.Text.Length == 1)
                {
                    textBoxResult.Text = "0";
                }
                else
                {
                    var input = textBoxResult.Text;
                    textBoxResult.Text = input.Substring(0, input.Length - 1);
                }

            }

        }
        /// <summary>
        /// Percentage function to calculate percentage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonPercentage_Click(object sender, EventArgs e)
        {

        }

        private void buttonMOD_Click(object sender, EventArgs e)
        {

        }
    }
}
