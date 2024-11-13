using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simaHesab
{
    public partial class SodoorFactor : Form
    {
        public SodoorFactor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KalaManagement kalaManagement = new KalaManagement();

            if (kalaManagement.ShowDialog()==DialogResult.OK) {
               txtCodeKala.Text= kalaManagement.data["kalaCode"];
                txtKalaName.Text= kalaManagement.data["kalaName"];
                txtPrice.Text= kalaManagement.data["price"];
                txtTedad.Text= kalaManagement.data["tedad"];
                txtTakhfif.Text="0";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtCodeKala.Text != "")
            {
                var rows = dataGridFactor.Rows;
                double takhfif = double.Parse((txtPrice.Text)) * double.Parse(txtTakhfif.Text) / 100;
                double totalPrice = (double.Parse(txtPrice.Text) - takhfif) * int.Parse(txtTedad.Text);
                rows.Add(new DataGridViewTextBoxCell().Value = rows.Count.ToString(), new DataGridViewTextBoxCell().Value = txtCodeKala.Text, new DataGridViewTextBoxCell().Value = txtKalaName.Text, new DataGridViewTextBoxCell().Value = txtTedad.Text, new DataGridViewTextBoxCell().Value = txtPrice.Text, new DataGridViewTextBoxCell().Value = txtTakhfif.Text, new DataGridViewTextBoxCell().Value = totalPrice.ToString());
            }
            else
            {
                MessageBox.Show("فیلد هارا برای درج پر کنید!!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SodoorFactor_Load(object sender, EventArgs e)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime now = DateTime.Now;

            int year = persianCalendar.GetYear(now);
            string month = persianCalendar.GetMonth(now).ToString().PadLeft(2,'0');
            string day = persianCalendar.GetDayOfMonth(now).ToString().PadLeft(2, '0');
            txtDate.Text = year+"/"+month+"/"+day;
        }

    }
}
