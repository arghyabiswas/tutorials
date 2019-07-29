namespace ASP.NET_Trainning
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new System.Windows.Forms.RichTextBox();
            this.dot = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 59);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(656, 47);
            this.result.TabIndex = 1;
            this.result.Text = "";
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(36, 353);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 23);
            this.dot.TabIndex = 2;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(36, 282);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 23);
            this.b7.TabIndex = 3;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.B7_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(36, 144);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 4;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(36, 212);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.B4_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(171, 353);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 23);
            this.b0.TabIndex = 6;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.B0_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(171, 282);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 23);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.B8_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(171, 212);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 23);
            this.b5.TabIndex = 8;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.B5_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(171, 144);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 9;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.B2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(325, 144);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 10;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.B3_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(325, 212);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 23);
            this.b6.TabIndex = 11;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.B6_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(325, 282);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 23);
            this.b9.TabIndex = 12;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.B9_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(325, 353);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 23);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(477, 353);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(477, 282);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 23);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Button14_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(477, 212);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(477, 144);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(593, 144);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "C";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ESSPL CALCULATOR";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.result);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
    }
}

