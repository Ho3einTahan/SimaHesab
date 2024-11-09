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
                var dataTable = await databaseHelper.GetAllFactor();
                var totalPrice = dataTable.Rows[0]["totalPrice"];
                totalPriceTextBox.Text = totalPrice.ToString();
                dataGridView1.DataSource = dataTable;
                CustomizeDataGridView();

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
            if (startDate.Text != "" && endDate.Text != "")
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();

                try
                {


                    var dataTable = await databaseHelper.GetFactorByDate(startDate.Text, endDate.Text);
                    var totalPrice = dataTable.Rows[0]["totalPrice"];
                    totalPriceTextBox.Text = totalPrice.ToString();
                    dataGridView1.DataSource = dataTable;
                    CustomizeDataGridView();
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
            if (dataGridView1.Columns.Contains("id"))
            {
                dataGridView1.Columns["id"].Width = 35;
                dataGridView1.Columns["id"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridView1.Columns["id"].HeaderText = "ردیف";
            }

            if (dataGridView1.Columns.Contains("factorNumber"))
            {
                dataGridView1.Columns["factorNumber"].Width = 65;
                dataGridView1.Columns["factorNumber"].HeaderText = "شماره فاکتور";
            }

            if (dataGridView1.Columns.Contains("factorPrice"))
                dataGridView1.Columns["factorPrice"].HeaderText = "مبلغ فاکتور";

            if (dataGridView1.Columns.Contains("totalPrice"))
                dataGridView1.Columns["totalPrice"].Visible = false;


            if (dataGridView1.Columns.Contains("receivePrice"))
                dataGridView1.Columns["receivePrice"].HeaderText = "مبلغ دریافتی";

            if (dataGridView1.Columns.Contains("type"))
                dataGridView1.Columns["type"].HeaderText = "نوع فاکتور";

            if (dataGridView1.Columns.Contains("status"))
                dataGridView1.Columns["status"].HeaderText = "وضعیت";

            if (dataGridView1.Columns.Contains("description"))
                dataGridView1.Columns["description"].HeaderText = "توضیحات";

            if (dataGridView1.Columns.Contains("saveDate"))
                dataGridView1.Columns["saveDate"].HeaderText = "زمان فاکتور";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا قصد خروج از این صفحه را دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.Close();

        }
    }
}
