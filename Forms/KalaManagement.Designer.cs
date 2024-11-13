namespace simaHesab
{
    partial class KalaManagement
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
            panel1 = new Panel();
            button2 = new Button();
            btnExit = new Button();
            comboboxSearch = new ComboBox();
            label1 = new Label();
            btnSearch = new Button();
            groupBox3 = new GroupBox();
            radioActiveStatus = new RadioButton();
            radioDeActiveStatus = new RadioButton();
            radioAllStatus = new RadioButton();
            groupBox1 = new GroupBox();
            radioAllMojoodi = new RadioButton();
            radioOnlyMojood = new RadioButton();
            txtSearch = new TextBox();
            dataGridKala = new DataGridView();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridKala).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(comboboxSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridKala);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 45, 0, 45);
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(912, 479);
            panel1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.WhiteSmoke;
            button2.BackgroundImage = Properties.Resources.submit;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(117, 437);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 24;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.BackgroundImage = Properties.Resources.logout;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 40);
            btnExit.TabIndex = 23;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // comboboxSearch
            // 
            comboboxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboboxSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboboxSearch.FormattingEnabled = true;
            comboboxSearch.Items.AddRange(new object[] { "کد", "نام" });
            comboboxSearch.Location = new Point(544, 12);
            comboboxSearch.Name = "comboboxSearch";
            comboboxSearch.Size = new Size(121, 23);
            comboboxSearch.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(671, 18);
            label1.Name = "label1";
            label1.Size = new Size(101, 13);
            label1.TabIndex = 21;
            label1.Text = "جست و جو براساس :";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Location = new Point(17, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(35, 35);
            btnSearch.TabIndex = 19;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(radioActiveStatus);
            groupBox3.Controls.Add(radioDeActiveStatus);
            groupBox3.Controls.Add(radioAllStatus);
            groupBox3.Font = new Font("Segoe UI", 7F);
            groupBox3.Location = new Point(69, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 34);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "فیلتر وضعیت";
            // 
            // radioActiveStatus
            // 
            radioActiveStatus.AutoSize = true;
            radioActiveStatus.Font = new Font("Segoe UI", 8F);
            radioActiveStatus.Location = new Point(132, 10);
            radioActiveStatus.Name = "radioActiveStatus";
            radioActiveStatus.Size = new Size(47, 17);
            radioActiveStatus.TabIndex = 2;
            radioActiveStatus.TabStop = true;
            radioActiveStatus.Text = "فعال";
            radioActiveStatus.UseVisualStyleBackColor = true;
            // 
            // radioDeActiveStatus
            // 
            radioDeActiveStatus.AutoSize = true;
            radioDeActiveStatus.Font = new Font("Segoe UI", 8F);
            radioDeActiveStatus.Location = new Point(63, 10);
            radioDeActiveStatus.Name = "radioDeActiveStatus";
            radioDeActiveStatus.Size = new Size(61, 17);
            radioDeActiveStatus.TabIndex = 1;
            radioDeActiveStatus.TabStop = true;
            radioDeActiveStatus.Text = "غیرفعال";
            radioDeActiveStatus.UseVisualStyleBackColor = true;
            // 
            // radioAllStatus
            // 
            radioAllStatus.AutoSize = true;
            radioAllStatus.Font = new Font("Segoe UI", 8F);
            radioAllStatus.Location = new Point(6, 10);
            radioAllStatus.Name = "radioAllStatus";
            radioAllStatus.Size = new Size(44, 17);
            radioAllStatus.TabIndex = 0;
            radioAllStatus.TabStop = true;
            radioAllStatus.Text = "همه";
            radioAllStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(radioAllMojoodi);
            groupBox1.Controls.Add(radioOnlyMojood);
            groupBox1.Font = new Font("Segoe UI", 7F);
            groupBox1.Location = new Point(334, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 34);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "فیلتر موجودی";
            // 
            // radioAllMojoodi
            // 
            radioAllMojoodi.AutoSize = true;
            radioAllMojoodi.Font = new Font("Segoe UI", 8F);
            radioAllMojoodi.Location = new Point(85, 10);
            radioAllMojoodi.Name = "radioAllMojoodi";
            radioAllMojoodi.Size = new Size(44, 17);
            radioAllMojoodi.TabIndex = 1;
            radioAllMojoodi.TabStop = true;
            radioAllMojoodi.Text = "همه";
            radioAllMojoodi.UseVisualStyleBackColor = true;
            // 
            // radioOnlyMojood
            // 
            radioOnlyMojood.AutoSize = true;
            radioOnlyMojood.Font = new Font("Segoe UI", 8F);
            radioOnlyMojood.Location = new Point(6, 10);
            radioOnlyMojood.Name = "radioOnlyMojood";
            radioOnlyMojood.Size = new Size(55, 17);
            radioOnlyMojood.TabIndex = 0;
            radioOnlyMojood.TabStop = true;
            radioOnlyMojood.Text = "موجود";
            radioOnlyMojood.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(778, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(122, 23);
            txtSearch.TabIndex = 1;
            // 
            // dataGridKala
            // 
            dataGridKala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridKala.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridKala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKala.Dock = DockStyle.Fill;
            dataGridKala.Location = new Point(0, 45);
            dataGridKala.Margin = new Padding(0);
            dataGridKala.Name = "dataGridKala";
            dataGridKala.Size = new Size(912, 389);
            dataGridKala.TabIndex = 0;
            // 
            // KalaManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 479);
            Controls.Add(panel1);
            Name = "KalaManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "انتخاب کالا";
            Load += KalaManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridKala).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridKala;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private RadioButton radioAllMojoodi;
        private RadioButton radioOnlyMojood;
        private GroupBox groupBox3;
        private RadioButton radioActiveStatus;
        private RadioButton radioDeActiveStatus;
        private RadioButton radioAllStatus;
        private Button btnSearch;
        private Label label1;
        private ComboBox comboboxSearch;
        private Button btnExit;
        private Button button2;
    }
}