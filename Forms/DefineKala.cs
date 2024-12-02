using simaHesab.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simaHesab
{
    public partial class DefineKala : Form
    {
        private DatabaseHelper databaseHelper;

        public DefineKala()
        {
            InitializeComponent();
            databaseHelper=new DatabaseHelper();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            SavingForm savingLoadingForm= new SavingForm();
            savingLoadingForm.Show();
            try
            {
                await databaseHelper.AddKalaAsync(txtKalaName.Text,int.Parse(txtMojoodiKala.Text),decimal.Parse(txtPrice.Text),decimal.Parse(txtTakhfif.Text));
                savingLoadingForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی در ثبت کالا رخ داد  : "+ex.ToString(),"خطا");
                savingLoadingForm.Close();
                
            }
        }
    }
}
