using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace simaHesab
{
    public partial class KalaManagement : Form
    {
        private readonly string connectionString = "Server=.\\pooyesh;Database=SimaHesab;User Id=sa;Password=PSC@560;TrustServerCertificate=True;";

        public KalaManagement()
        {
            InitializeComponent();
        }

        private async void KalaManagement_Load(object sender, EventArgs e)
        {
            var loadingForm = new LoadingForm();
            loadingForm.Show();
            this.Enabled = false;

            try
            {
                var dataTable = await LoadDataFromDatabaseAsync();
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

        private async Task<DataTable> LoadDataFromDatabaseAsync()
        {
            return await Task.Run(() =>
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM kala";
                using var adapter = new SqlDataAdapter(query, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            });
        }




        private void CustomizeDataGridView()
        {
            if (dataGridView1.Columns.Contains("kalaId"))
            {
                dataGridView1.Columns["kalaId"].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                dataGridView1.Columns["kalaId"].HeaderText = "شناسه کالا";
            }

            if (dataGridView1.Columns.Contains("kalaName"))
                dataGridView1.Columns["kalaName"].HeaderText = "نام کالا";

            if (dataGridView1.Columns.Contains("barcode"))
                dataGridView1.Columns["barcode"].HeaderText = "بارکد";

            if (dataGridView1.Columns.Contains("price"))
                dataGridView1.Columns["price"].HeaderText = "قیمت";

            if (dataGridView1.Columns.Contains("tedad"))
                dataGridView1.Columns["tedad"].HeaderText = "تعداد";

            if (dataGridView1.Columns.Contains("takhfif"))
                dataGridView1.Columns["takhfif"].HeaderText = "تخفیف";

            if (dataGridView1.Columns.Contains("saveDate"))
                dataGridView1.Columns["saveDate"].Width = 60;
        }

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا قصد خروج از این صفحه را دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }
    }
}
