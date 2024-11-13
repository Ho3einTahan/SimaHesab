using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using simaHesab.Classes;

namespace simaHesab
{
    public partial class KalaManagement : Form
    {
       public Dictionary<string, string> data = new Dictionary<string, string>();
        private DatabaseHelper databaseHelper;
        public KalaManagement()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
        }

        private void KalaManagement_Load(object sender, EventArgs e)
        {
            GetAllKalaFromDatabase();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllKalaFromDatabase();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا قصد خروج از این صفحه را دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }

        private async void GetAllKalaFromDatabase()
        {

            this.Enabled = false;

            try
            {
                string query = "SELECT * FROM kala WHERE 1=1";  // شرط 1=1 به این معنی است که هیچ‌چیز فیلتر نشود.
                if (comboboxSearch.SelectedItem != null && txtSearch.Text != "")
                {
                    if (comboboxSearch.SelectedItem.ToString() == "نام")
                    {
                        query += " AND Name LIKE '%" + txtSearch.Text + "%' ";
                    }
                    else if (comboboxSearch.SelectedItem.ToString() == "کد")
                    {
                        int code;
                        if (int.TryParse(txtSearch.Text, out code))
                        {
                            query += " AND Code = " + code;  // استفاده از عدد برای جستجو
                        }
                        else
                        {
                            MessageBox.Show("کد وارد شده صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (radioActiveStatus.Checked)
                {
                    query += " AND isActive = 1";  // فرض کنید که وضعیت کالا 'Active' است.
                }
                else if (radioDeActiveStatus.Checked)
                {
                    query += " AND isActive = 0";  // فرض کنید که وضعیت کالا 'DeActive' است.
                }

                if (radioOnlyMojood.Checked)
                {
                    query += " AND Tedad > 0";  // فرض می‌کنیم که Tedad موجودی کالا باشد.
                }
                else if (radioAllMojoodi.Checked)
                {
                }

                var dataTable = await databaseHelper.GetAllKalaAsync(query);
                dataGridKala.DataSource = dataTable;
                CustomizeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;
            }

        }

        private void CustomizeDataGridView()
        {
            if (dataGridKala.Columns.Contains("Code"))
            {
                dataGridKala.Columns["Code"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridKala.Columns["Code"].HeaderText = "کد کالا";
            }

            if (dataGridKala.Columns.Contains("Name"))
                dataGridKala.Columns["Name"].HeaderText = "نام کالا";


            if (dataGridKala.Columns.Contains("price"))
                dataGridKala.Columns["price"].HeaderText = "قیمت";

            if (dataGridKala.Columns.Contains("Tedad"))
                dataGridKala.Columns["Tedad"].HeaderText = "موجودی";

            if (dataGridKala.Columns.Contains("takhfif"))
                dataGridKala.Columns["takhfif"].HeaderText = "تخفیف";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridKala.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridKala.Rows[rowIndex];
            data.Add("kalaCode", selectedRow.Cells[0].Value.ToString());
            data.Add("kalaName", selectedRow.Cells[1].Value.ToString());
            data.Add("tedad", selectedRow.Cells[2].Value.ToString());
            data.Add("price", selectedRow.Cells[3].Value.ToString());
            data.Add("isActive", selectedRow.Cells[4].Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
