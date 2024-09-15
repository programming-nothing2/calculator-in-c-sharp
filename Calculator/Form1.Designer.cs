namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btn_clear = new Button();
            btn_back = new Button();
            btn_divide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn_plus = new Button();
            btn_minus = new Button();
            btn_product = new Button();
            btn_equal = new Button();
            btn_dot = new Button();
            btn0 = new Button();
            btn00 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(16, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 57);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(255, 128, 128);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn_clear.ForeColor = Color.Black;
            btn_clear.Location = new Point(16, 89);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(76, 67);
            btn_clear.TabIndex = 1;
            btn_clear.Text = "AC";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gray;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.Black;
            btn_back.Location = new Point(118, 89);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(76, 67);
            btn_back.TabIndex = 2;
            btn_back.Text = "←";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.Gray;
            btn_divide.Cursor = Cursors.Hand;
            btn_divide.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn_divide.ForeColor = Color.Black;
            btn_divide.Location = new Point(218, 89);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(76, 67);
            btn_divide.TabIndex = 3;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gray;
            btn7.Cursor = Cursors.Hand;
            btn7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(16, 174);
            btn7.Name = "btn7";
            btn7.Size = new Size(76, 67);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gray;
            btn8.Cursor = Cursors.Hand;
            btn8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(118, 174);
            btn8.Name = "btn8";
            btn8.Size = new Size(76, 67);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gray;
            btn9.Cursor = Cursors.Hand;
            btn9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(218, 174);
            btn9.Name = "btn9";
            btn9.Size = new Size(76, 67);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gray;
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(16, 263);
            btn4.Name = "btn4";
            btn4.Size = new Size(76, 67);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gray;
            btn5.Cursor = Cursors.Hand;
            btn5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(118, 263);
            btn5.Name = "btn5";
            btn5.Size = new Size(76, 67);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gray;
            btn6.Cursor = Cursors.Hand;
            btn6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(218, 263);
            btn6.Name = "btn6";
            btn6.Size = new Size(76, 67);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.Gray;
            btn_plus.Cursor = Cursors.Hand;
            btn_plus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn_plus.ForeColor = Color.Black;
            btn_plus.Location = new Point(320, 263);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(76, 67);
            btn_plus.TabIndex = 12;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.Gray;
            btn_minus.Cursor = Cursors.Hand;
            btn_minus.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_minus.ForeColor = Color.Black;
            btn_minus.Location = new Point(320, 174);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(76, 67);
            btn_minus.TabIndex = 11;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_product
            // 
            btn_product.BackColor = Color.Gray;
            btn_product.Cursor = Cursors.Hand;
            btn_product.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_product.ForeColor = Color.Black;
            btn_product.Location = new Point(320, 89);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(76, 67);
            btn_product.TabIndex = 10;
            btn_product.Text = "x";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // btn_equal
            // 
            btn_equal.BackColor = Color.Gray;
            btn_equal.Cursor = Cursors.Hand;
            btn_equal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn_equal.ForeColor = Color.Black;
            btn_equal.Location = new Point(320, 346);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(76, 156);
            btn_equal.TabIndex = 20;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = false;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_dot
            // 
            btn_dot.BackColor = Color.Gray;
            btn_dot.Cursor = Cursors.Hand;
            btn_dot.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn_dot.ForeColor = Color.Black;
            btn_dot.Location = new Point(218, 435);
            btn_dot.Name = "btn_dot";
            btn_dot.Size = new Size(76, 67);
            btn_dot.TabIndex = 18;
            btn_dot.Text = ".";
            btn_dot.UseVisualStyleBackColor = false;
            btn_dot.Click += btn_dot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gray;
            btn0.Cursor = Cursors.Hand;
            btn0.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(118, 435);
            btn0.Name = "btn0";
            btn0.Size = new Size(76, 67);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn00
            // 
            btn00.BackColor = Color.Gray;
            btn00.Cursor = Cursors.Hand;
            btn00.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn00.ForeColor = Color.Black;
            btn00.Location = new Point(16, 435);
            btn00.Name = "btn00";
            btn00.Size = new Size(76, 67);
            btn00.TabIndex = 16;
            btn00.Text = "00";
            btn00.UseVisualStyleBackColor = false;
            btn00.Click += btn00_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gray;
            btn3.Cursor = Cursors.Hand;
            btn3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(218, 346);
            btn3.Name = "btn3";
            btn3.Size = new Size(76, 67);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gray;
            btn2.Cursor = Cursors.Hand;
            btn2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(118, 346);
            btn2.Name = "btn2";
            btn2.Size = new Size(76, 67);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gray;
            btn1.Cursor = Cursors.Hand;
            btn1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(16, 346);
            btn1.Name = "btn1";
            btn1.Size = new Size(76, 67);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 200);
            ClientSize = new Size(411, 519);
            Controls.Add(btn_equal);
            Controls.Add(btn_dot);
            Controls.Add(btn0);
            Controls.Add(btn00);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn_plus);
            Controls.Add(btn_minus);
            Controls.Add(btn_product);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn_divide);
            Controls.Add(btn_back);
            Controls.Add(btn_clear);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "     Simple Calculator ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_clear;
        private Button btn_back;
        private Button btn_divide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn_plus;
        private Button btn_minus;
        private Button btn_product;
        private Button btn_equal;
        private Button btn_dot;
        private Button btn0;
        private Button btn00;
        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}
