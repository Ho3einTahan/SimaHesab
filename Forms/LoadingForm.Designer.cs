namespace simaHesab
{
    partial class LoadingForm
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
            progressBarLoading = new ProgressBar();
            loadingLabel = new Label();
            SuspendLayout();
            // 
            // progressBarLoading
            // 
            progressBarLoading.Location = new Point(12, 49);
            progressBarLoading.Name = "progressBarLoading";
            progressBarLoading.Size = new Size(215, 25);
            progressBarLoading.TabIndex = 0;
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            loadingLabel.ForeColor = Color.Black;
            loadingLabel.Location = new Point(42, 20);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.RightToLeft = RightToLeft.Yes;
            loadingLabel.Size = new Size(150, 15);
            loadingLabel.TabIndex = 1;
            loadingLabel.Text = "درحال بارگذاری اطلاعات ...";
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(233, 91);
            Controls.Add(loadingLabel);
            Controls.Add(progressBarLoading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "LoadingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarLoading;
        private Label loadingLabel;
    }
}