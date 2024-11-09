namespace simaHesab
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
            menuStrip1 = new MenuStrip();
            عملیاتToolStripMenuItem = new ToolStripMenuItem();
            defineKala = new ToolStripMenuItem();
            مدیریتکالاToolStripMenuItem = new ToolStripMenuItem();
            فروشمحصولToolStripMenuItem = new ToolStripMenuItem();
            تنظیماتToolStripMenuItem = new ToolStripMenuItem();
            لیستفاکتورهاToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { عملیاتToolStripMenuItem, تنظیماتToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(922, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // عملیاتToolStripMenuItem
            // 
            عملیاتToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defineKala, مدیریتکالاToolStripMenuItem, فروشمحصولToolStripMenuItem, لیستفاکتورهاToolStripMenuItem });
            عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            عملیاتToolStripMenuItem.Size = new Size(55, 20);
            عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // defineKala
            // 
            defineKala.Name = "defineKala";
            defineKala.Size = new Size(180, 22);
            defineKala.Text = "تعریف کالا";
            defineKala.Click += defineKala_Click;
            // 
            // مدیریتکالاToolStripMenuItem
            // 
            مدیریتکالاToolStripMenuItem.Name = "مدیریتکالاToolStripMenuItem";
            مدیریتکالاToolStripMenuItem.Size = new Size(180, 22);
            مدیریتکالاToolStripMenuItem.Text = "مدیریت کالا";
            مدیریتکالاToolStripMenuItem.Click += مدیریتکالاToolStripMenuItem_Click;
            // 
            // فروشمحصولToolStripMenuItem
            // 
            فروشمحصولToolStripMenuItem.Name = "فروشمحصولToolStripMenuItem";
            فروشمحصولToolStripMenuItem.Size = new Size(180, 22);
            فروشمحصولToolStripMenuItem.Text = "فروش محصول";
            فروشمحصولToolStripMenuItem.Click += فروشمحصولToolStripMenuItem_Click;
            // 
            // تنظیماتToolStripMenuItem
            // 
            تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            تنظیماتToolStripMenuItem.Size = new Size(62, 20);
            تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // لیستفاکتورهاToolStripMenuItem
            // 
            لیستفاکتورهاToolStripMenuItem.Name = "لیستفاکتورهاToolStripMenuItem";
            لیستفاکتورهاToolStripMenuItem.Size = new Size(180, 22);
            لیستفاکتورهاToolStripMenuItem.Text = "لیست فاکتور ها";
            لیستفاکتورهاToolStripMenuItem.Click += لیستفاکتورهاToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 533);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem عملیاتToolStripMenuItem;
        private ToolStripMenuItem defineKala;
        private ToolStripMenuItem مدیریتکالاToolStripMenuItem;
        private ToolStripMenuItem تنظیماتToolStripMenuItem;
        private ToolStripMenuItem فروشمحصولToolStripMenuItem;
        private ToolStripMenuItem لیستفاکتورهاToolStripMenuItem;
    }
}
