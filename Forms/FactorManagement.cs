using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simaHesab.Classes;

namespace simaHesab
{
    public partial class FactorManagement : Form
    {
        private DatabaseHelper databaseHelper;

        public FactorManagement()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
        }


        private async void FactorManagement_Load(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            this.Enabled = false;

            try
            {
                var dataTable = await databaseHelper.GetAllFactorAsync();
                if (dataTable.Rows.Count>0) {
                    var totalPrice = dataTable.Rows[0]["totalPrice"];
                    totalPriceTextBox.Text = totalPrice.ToString();
                    dataGridView1.DataSource = dataTable;
                    CustomizeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                loadingForm.Close();
                this.Enabled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int factorNumber=0;

            if ((txtStartDate.Text != "" && txtEndDate.Text != "")|| int.TryParse(txtFactorNumber.Text,out  factorNumber))
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();

                try
                {
                    var dataTable = await databaseHelper.GetFactorByDate(txtStartDate.Text, txtEndDate.Text, factorNumber);
                    if (dataTable.Rows.Count>0) {
                        var totalPrice = dataTable.Rows[0]["totalPrice"];
                        totalPriceTextBox.Text = totalPrice.ToString();
                        dataGridView1.DataSource = dataTable;
                        CustomizeDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    loadingForm.Close();
                }
            }
            else
            {
                MessageBox.Show("تاریخ را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void CustomizeDataGridView()
        {
            if (dataGridView1.Columns.Contains("codeFactor"))
            {
                dataGridView1.Columns["codeFactor"].HeaderText = "شماره فاکتور";
            }

            if (dataGridView1.Columns.Contains("date"))
            {
                dataGridView1.Columns["date"].Width = 65;
                dataGridView1.Columns["date"].HeaderText = "تاریخ";
            }

            if (dataGridView1.Columns.Contains("sharh"))
                dataGridView1.Columns["sharh"].HeaderText = "شرح";

            if (dataGridView1.Columns.Contains("totalPrice"))
                dataGridView1.Columns["totalPrice"].Visible = false;


            if (dataGridView1.Columns.Contains("factorPrice"))
                dataGridView1.Columns["factorPrice"].HeaderText = "جمع کل فاکتور";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا قصد خروج از این صفحه را دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.Close();

        }
    }
}
