namespace simaHesab
{
    partial class SavingForm
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
            loadingLabel = new Label();
            progressBarSaving = new ProgressBar();
            SuspendLayout();
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            loadingLabel.ForeColor = Color.Black;
            loadingLabel.Location = new Point(42, 21);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.RightToLeft = RightToLeft.Yes;
            loadingLabel.Size = new Size(149, 15);
            loadingLabel.TabIndex = 3;
            loadingLabel.Text = "درحال ذخیره سازی اطلاعات";
            // 
            // progressBarSaving
            // 
            progressBarSaving.Location = new Point(12, 50);
            progressBarSaving.Name = "progressBarSaving";
            progressBarSaving.Size = new Size(215, 25);
            progressBarSaving.TabIndex = 2;
            // 
            // SavingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(239, 97);
            ControlBox = false;
            Controls.Add(loadingLabel);
            Controls.Add(progressBarSaving);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SavingForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loadingLabel;
        private ProgressBar progressBarSaving;
    }
}