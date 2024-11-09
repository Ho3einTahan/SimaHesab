using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace simaHesab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void defineKala_Click(object sender, EventArgs e)
        {
            DefineKala defineKalaForm = new DefineKala();
            defineKalaForm.ShowDialog();
        }


        private void فروشمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SodoorFactor sodoorFactor = new SodoorFactor();
            sodoorFactor.Show();
        }

        private void مدیریتکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KalaManagement kalaManagement = new KalaManagement();
            kalaManagement.ShowDialog();
        }

        private void لیستفاکتورهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactorManagement factorManagement=new FactorManagement();
            factorManagement.Show();
        }
    }
}
