namespace simaHesab
{
    partial class SodoorFactor
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
            panel2 = new Panel();
            lblFactorNumber = new Label();
            txtFactorNumber = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            lblDate = new Label();
            txtDate = new TextBox();
            btnPrint = new Button();
            btnSave = new Button();
            btnExit = new Button();
            dataGridFactor = new DataGridView();
            satr = new DataGridViewTextBoxColumn();
            codeKala = new DataGridViewTextBoxColumn();
            kalaName = new DataGridViewTextBoxColumn();
            tedad = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            takhfif = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            textBox8 = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            txtKalaName = new TextBox();
            lblKalaName = new Label();
            btnSubmit = new Button();
            label4 = new Label();
            txtTakhfif = new TextBox();
            txtTotalPrice = new TextBox();
            btnDelete = new Button();
            lblTotalPrice = new Label();
            txtSharh = new TextBox();
            txtTedad = new TextBox();
            lblSharh = new Label();
            label8 = new Label();
            txtCodeKala = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblCodeKala = new Label();
            button3 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFactor).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lblFactorNumber);
            panel2.Controls.Add(txtFactorNumber);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 3, 3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 450);
            panel2.TabIndex = 4;
            // 
            // lblFactorNumber
            // 
            lblFactorNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFactorNumber.AutoSize = true;
            lblFactorNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFactorNumber.ForeColor = SystemColors.MenuHighlight;
            lblFactorNumber.Location = new Point(698, 5);
            lblFactorNumber.Name = "lblFactorNumber";
            lblFactorNumber.RightToLeft = RightToLeft.Yes;
            lblFactorNumber.Size = new Size(93, 19);
            lblFactorNumber.TabIndex = 4;
            lblFactorNumber.Text = "شماره فاکتور :";
            // 
            // txtFactorNumber
            // 
            txtFactorNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFactorNumber.Location = new Point(574, 4);
            txtFactorNumber.Name = "txtFactorNumber";
            txtFactorNumber.ReadOnly = true;
            txtFactorNumber.Size = new Size(121, 23);
            txtFactorNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(709, 7);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(dataGridFactor);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 130, 0, 45);
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 18;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDate.ForeColor = SystemColors.MenuHighlight;
            lblDate.Location = new Point(95, 8);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(46, 19);
            lblDate.TabIndex = 2;
            lblDate.Text = "تاریخ :";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(6, 7);
            txtDate.Name = "txtDate";
            txtDate.RightToLeft = RightToLeft.No;
            txtDate.Size = new Size(85, 23);
            txtDate.TabIndex = 3;
            txtDate.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrint.BackColor = Color.WhiteSmoke;
            btnPrint.BackgroundImage = Properties.Resources.print;
            btnPrint.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrint.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(688, 408);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(110, 40);
            btnPrint.TabIndex = 27;
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.BackgroundImage = Properties.Resources.submit;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(119, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 26;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.BackgroundImage = Properties.Resources.logout;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(3, 407);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 40);
            btnExit.TabIndex = 25;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // dataGridFactor
            // 
            dataGridFactor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFactor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridFactor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFactor.Columns.AddRange(new DataGridViewColumn[] { satr, codeKala, kalaName, tedad, price, takhfif, totalPrice });
            dataGridFactor.Dock = DockStyle.Fill;
            dataGridFactor.GridColor = SystemColors.MenuHighlight;
            dataGridFactor.Location = new Point(0, 130);
            dataGridFactor.Name = "dataGridFactor";
            dataGridFactor.RightToLeft = RightToLeft.Yes;
            dataGridFactor.Size = new Size(800, 275);
            dataGridFactor.TabIndex = 0;
            dataGridFactor.MouseDoubleClick += dataGridFactor_MouseDoubleClick;
            // 
            // satr
            // 
            satr.HeaderText = "ردیف";
            satr.Name = "satr";
            // 
            // codeKala
            // 
            codeKala.HeaderText = "کدکالا";
            codeKala.Name = "codeKala";
            // 
            // kalaName
            // 
            kalaName.HeaderText = "نام کالا";
            kalaName.Name = "kalaName";
            // 
            // tedad
            // 
            tedad.HeaderText = "تعداد";
            tedad.Name = "tedad";
            // 
            // price
            // 
            price.HeaderText = "قیمت واحد";
            price.Name = "price";
            // 
            // takhfif
            // 
            takhfif.HeaderText = "تخفیف";
            takhfif.Name = "takhfif";
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "قیمت کل";
            totalPrice.Name = "totalPrice";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox8.BackColor = SystemColors.ActiveCaption;
            textBox8.Location = new Point(380, 300);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(121, 23);
            textBox8.TabIndex = 17;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = SystemColors.MenuHighlight;
            label10.Location = new Point(503, 301);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(63, 19);
            label10.TabIndex = 16;
            label10.Text = "مبلغ کل :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(txtKalaName);
            groupBox1.Controls.Add(lblKalaName);
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTakhfif);
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(lblTotalPrice);
            groupBox1.Controls.Add(txtSharh);
            groupBox1.Controls.Add(txtTedad);
            groupBox1.Controls.Add(lblSharh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCodeKala);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblCodeKala);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(3, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(794, 90);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "افزودن کالا";
            // 
            // txtKalaName
            // 
            txtKalaName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtKalaName.BackColor = SystemColors.ActiveCaption;
            txtKalaName.Font = new Font("B Nazanin", 10F, FontStyle.Bold);
            txtKalaName.Location = new Point(408, 19);
            txtKalaName.Name = "txtKalaName";
            txtKalaName.Size = new Size(117, 29);
            txtKalaName.TabIndex = 32;
            // 
            // lblKalaName
            // 
            lblKalaName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKalaName.AutoSize = true;
            lblKalaName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblKalaName.ForeColor = SystemColors.MenuHighlight;
            lblKalaName.Location = new Point(531, 25);
            lblKalaName.Name = "lblKalaName";
            lblKalaName.RightToLeft = RightToLeft.Yes;
            lblKalaName.Size = new Size(58, 19);
            lblKalaName.TabIndex = 31;
            lblKalaName.Text = "نام کالا :";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Green;
            btnSubmit.Location = new Point(109, 55);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 35);
            btnSubmit.TabIndex = 30;
            btnSubmit.Text = "تایید";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(280, 25);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(48, 15);
            label4.TabIndex = 19;
            label4.Text = "% درصد";
            // 
            // txtTakhfif
            // 
            txtTakhfif.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTakhfif.BackColor = SystemColors.ActiveCaption;
            txtTakhfif.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            txtTakhfif.Location = new Point(332, 16);
            txtTakhfif.Name = "txtTakhfif";
            txtTakhfif.Size = new Size(58, 33);
            txtTakhfif.TabIndex = 18;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalPrice.BackColor = SystemColors.ActiveCaption;
            txtTotalPrice.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            txtTotalPrice.Location = new Point(223, 56);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(105, 33);
            txtTotalPrice.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(3, 55);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.Navy;
            lblTotalPrice.Location = new Point(330, 64);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.RightToLeft = RightToLeft.Yes;
            lblTotalPrice.Size = new Size(63, 19);
            lblTotalPrice.TabIndex = 16;
            lblTotalPrice.Text = "مبلغ کل :";
            // 
            // txtSharh
            // 
            txtSharh.BackColor = Color.White;
            txtSharh.Font = new Font("Segoe UI", 11F);
            txtSharh.Location = new Point(3, 19);
            txtSharh.Name = "txtSharh";
            txtSharh.Size = new Size(216, 27);
            txtSharh.TabIndex = 11;
            // 
            // txtTedad
            // 
            txtTedad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTedad.BackColor = Color.LightSeaGreen;
            txtTedad.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            txtTedad.Location = new Point(615, 55);
            txtTedad.Name = "txtTedad";
            txtTedad.Size = new Size(105, 33);
            txtTedad.TabIndex = 13;
            txtTedad.TextChanged += txtTedad_TextChanged;
            // 
            // lblSharh
            // 
            lblSharh.AutoSize = true;
            lblSharh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSharh.ForeColor = SystemColors.MenuHighlight;
            lblSharh.Location = new Point(223, 24);
            lblSharh.Name = "lblSharh";
            lblSharh.RightToLeft = RightToLeft.Yes;
            lblSharh.Size = new Size(43, 19);
            lblSharh.TabIndex = 10;
            lblSharh.Text = "شرح :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(724, 62);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(48, 19);
            label8.TabIndex = 12;
            label8.Text = "تعداد :";
            // 
            // txtCodeKala
            // 
            txtCodeKala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCodeKala.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            txtCodeKala.Location = new Point(615, 19);
            txtCodeKala.Name = "txtCodeKala";
            txtCodeKala.Size = new Size(86, 33);
            txtCodeKala.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrice.BackColor = SystemColors.ActiveCaption;
            txtPrice.Font = new Font("B Nazanin", 12F, FontStyle.Bold);
            txtPrice.Location = new Point(408, 55);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(117, 33);
            txtPrice.TabIndex = 15;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrice.ForeColor = SystemColors.MenuHighlight;
            lblPrice.Location = new Point(528, 63);
            lblPrice.Name = "lblPrice";
            lblPrice.RightToLeft = RightToLeft.Yes;
            lblPrice.Size = new Size(80, 19);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "قیمت واحد :";
            // 
            // lblCodeKala
            // 
            lblCodeKala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCodeKala.AutoSize = true;
            lblCodeKala.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodeKala.ForeColor = SystemColors.MenuHighlight;
            lblCodeKala.Location = new Point(736, 24);
            lblCodeKala.Name = "lblCodeKala";
            lblCodeKala.RightToLeft = RightToLeft.Yes;
            lblCodeKala.Size = new Size(51, 19);
            lblCodeKala.TabIndex = 8;
            lblCodeKala.Text = "کدکالا :";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            button3.Location = new Point(703, 23);
            button3.Name = "button3";
            button3.Size = new Size(29, 23);
            button3.TabIndex = 4;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SodoorFactor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Name = "SodoorFactor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فروش کالا/صدور فاکتور";
            Load += SodoorFactor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFactor).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblFactorNumber;
        private TextBox txtTedad;
        private Label label8;
        private TextBox txtDate;
        private Label lblDate;
        private Label lblCodeKala;
        private TextBox txtSharh;
        private Label lblSharh;
        private TextBox txtFactorNumber;
        private Label label1;
        private TextBox textBox8;
        private Label label10;
        private Panel panel3;
        private DataGridView dataGridFactor;
        private Button button3;
        private TextBox txtCodeKala;
        private Button btnPrint;
        private Button btnSave;
        private Button btnExit;
        private GroupBox groupBox1;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private Button btnDelete;
        private Button btnSubmit;
        private Label label4;
        private TextBox txtTakhfif;
        private DataGridViewTextBoxColumn satr;
        private DataGridViewTextBoxColumn codeKala;
        private DataGridViewTextBoxColumn kalaName;
        private DataGridViewTextBoxColumn tedad;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn takhfif;
        private DataGridViewTextBoxColumn totalPrice;
        private TextBox txtKalaName;
        private Label lblKalaName;
    }
}