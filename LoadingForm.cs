using System;
using System.Windows.Forms;
using System.Drawing;

namespace simaHesab
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            CustomizeControls();
        }

        private void CustomizeControls()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            progressBarLoading.Style = ProgressBarStyle.Marquee;
            progressBarLoading.MarqueeAnimationSpeed = 30;
        }
    }
}
