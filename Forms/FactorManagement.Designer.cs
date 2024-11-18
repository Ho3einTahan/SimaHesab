namespace simaHesab
{
    partial class FactorManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtStartDate = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtFactorNumber = new TextBox();
            label6 = new Label();
            button1 = new Button();
            btnExit = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            totalPriceTextBox = new TextBox();
            txtEndDate = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtStartDate
            // 
            txtStartDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtStartDate.BackColor = SystemColors.GradientActiveCaption;
            txtStartDate.Location = new Point(626, 12);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(115, 23);
            txtStartDate.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(743, 17);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(48, 15);
            label2.TabIndex = 7;
            label2.Text = "از تاریخ :";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFactorNumber);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(totalPriceTextBox);
            panel1.Controls.Add(txtEndDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtStartDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 50, 0, 100);
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 8;
            // 
            // txtFactorNumber
            // 
            txtFactorNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactorNumber.BackColor = SystemColors.GradientActiveCaption;
            txtFactorNumber.Location = new Point(228, 12);
            txtFactorNumber.Name = "txtFactorNumber";
            txtFactorNumber.Size = new Size(115, 23);
            txtFactorNumber.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(344, 16);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(76, 15);
            label6.TabIndex = 20;
            label6.Text = "شماره فاکتور :";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImage = Properties.Resources.search;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(187, 5);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.BackgroundImage = Properties.Resources.logout;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(2, 408);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 40);
            btnExit.TabIndex = 17;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(478, 426);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(39, 15);
            label5.TabIndex = 16;
            label5.Text = "مانده :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(477, 392);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(69, 15);
            label4.TabIndex = 15;
            label4.Text = "دریافتی کل :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(477, 359);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(52, 15);
            label3.TabIndex = 14;
            label3.Text = "مبلغ کل :";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox5.BackColor = SystemColors.GradientActiveCaption;
            textBox5.Location = new Point(316, 421);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 23);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox4.BackColor = SystemColors.GradientActiveCaption;
            textBox4.Location = new Point(316, 388);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 23);
            textBox4.TabIndex = 12;
            // 
            // totalPriceTextBox
            // 
            totalPriceTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalPriceTextBox.BackColor = SystemColors.GradientActiveCaption;
            totalPriceTextBox.Location = new Point(316, 355);
            totalPriceTextBox.Name = "totalPriceTextBox";
            totalPriceTextBox.Size = new Size(159, 23);
            totalPriceTextBox.TabIndex = 11;
            // 
            // txtEndDate
            // 
            txtEndDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEndDate.BackColor = SystemColors.GradientActiveCaption;
            txtEndDate.Location = new Point(441, 12);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(115, 23);
            txtEndDate.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(559, 16);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(47, 15);
            label1.TabIndex = 9;
            label1.Text = "تا تاریخ :";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 300);
            panel2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.Size = new Size(800, 300);
            dataGridView1.TabIndex = 0;
            // 
            // FactorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FactorManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاکتورها";
            Load += FactorManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtStartDate;
        private Label label2;
        private Panel panel1;
        private TextBox txtEndDate;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox totalPriceTextBox;
        private Button btnExit;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtFactorNumber;
        private Label label6;
    }
}