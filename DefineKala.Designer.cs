namespace simaHesab
{
    partial class DefineKala
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "تعریف کالا";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 100);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(46, 15);
            label6.TabIndex = 9;
            label6.Text = "تخفیف :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(362, 97);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "درصد تخفیف";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 57);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "تعداد :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 54);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "تعداد کالا";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 57);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "نام کالا :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 57);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "قیمت :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 54);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "قیمت کالا";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 19);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "1401/12/01";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "تاریخ :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(362, 54);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "نام کالا";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DefineKala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 322);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DefineKala";
            Text = "DefineKala";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
    }
}