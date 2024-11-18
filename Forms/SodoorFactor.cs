using simaHesab.Classes;
using System.Globalization;

namespace simaHesab
{
    public partial class SodoorFactor : Form
    {

        private DatabaseHelper databaseHelper;

        public SodoorFactor()
        {
            InitializeComponent();
            databaseHelper=new DatabaseHelper();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KalaManagement kalaManagement = new KalaManagement();

            if (kalaManagement.ShowDialog() == DialogResult.OK)
            {
                txtCodeKala.Text = kalaManagement.data["kalaCode"];
                txtKalaName.Text = kalaManagement.data["kalaName"];
                txtPrice.Text = kalaManagement.data["price"];
                txtTedad.Text = kalaManagement.data["tedad"];
                txtTakhfif.Text = "0";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtCodeKala.Text != "")
            {
                var rows = dataGridFactor.Rows;
                double takhfif = double.Parse(txtPrice.Text.Replace(".","")) * double.Parse(txtTakhfif.Text.Replace(".", "")) / 100;
                double totalPrice = (double.Parse(txtPrice.Text.Replace(".", "")) - takhfif) * int.Parse(txtTedad.Text.Replace(".", ""));

                bool exists = false;

                foreach (DataGridViewRow row in rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == txtCodeKala.Text)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    dataGridFactor.Rows.Add(
                        rows.Count + 1,
                        txtCodeKala.Text,
                        txtKalaName.Text,
                        txtTedad.Text,
                        txtPrice.Text,
                        txtTakhfif.Text,
                        totalPrice.ToString()
                    );

                    txtCodeKala.Clear();
                    txtKalaName.Clear();
                    txtTedad.Clear();
                    txtPrice.Clear();
                    txtTakhfif.Clear();
                }
                else
                {
                    MessageBox.Show("این کد کالا قبلاً اضافه شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("فیلد هارا برای درج پر کنید!!", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void SodoorFactor_Load(object sender, EventArgs e)
        {   
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime now = DateTime.Now;

            int year = persianCalendar.GetYear(now);
            string month = persianCalendar.GetMonth(now).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(now).ToString().PadLeft(2, '0');
            txtDate.Text = year + "/" + month + "/" + day;

          txtFactorNumber.Text=(await databaseHelper.GetMaxCodeFactorAsync()).ToString();

        }

        private void dataGridFactor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow CurrentRow = dataGridFactor.CurrentRow;
            txtCodeKala.Text = CurrentRow.Cells[1].Value.ToString();
            txtKalaName.Text = CurrentRow.Cells[2].Value.ToString();
            txtTedad.Text = CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = CurrentRow.Cells[4].Value.ToString();
            txtTakhfif.Text = CurrentRow.Cells[5].Value.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFactorNumber.Text) || !int.TryParse(txtFactorNumber.Text, out int factorNumber))
            {
                MessageBox.Show("شماره فاکتور معتبر نیست.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("تاریخ یا شرح نمی‌تواند خالی باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SavingForm savingForm = new SavingForm();
            savingForm.Show();
            this.Enabled = false;

            try
            {
                string date = txtDate.Text;
                string sharh = txtSharh.Text;


                decimal totalPrice = 0;

                foreach (DataGridViewRow row in dataGridFactor.Rows)
                {
                    if (row.IsNewRow) continue;

                    var cellValue = row.Cells["totalPrice"].Value;

                    if (cellValue != null && decimal.TryParse(cellValue.ToString(), out decimal price))
                    {
                        totalPrice += price;
                    }
                }

                totalPrice = Math.Round(totalPrice,2);

                await databaseHelper.AddNewFactorAsync(date, totalPrice, sharh);

                DataGridViewRowCollection rows = dataGridFactor.Rows;

                foreach (DataGridViewRow rizFactorRow in rows)
                {
                    if (rizFactorRow.IsNewRow) continue;
                    if (rizFactorRow.Cells[1].Value == null || rizFactorRow.Cells[3].Value == null || rizFactorRow.Cells[5].Value == null)
                    {
                        MessageBox.Show("برخی از سلول‌های جدول خالی هستند. لطفاً تمام اطلاعات را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    if (!int.TryParse(rizFactorRow.Cells[1].Value.ToString(), out int codeKala) ||
                        !double.TryParse(rizFactorRow.Cells[3].Value.ToString(), out double tedad) ||
                        !double.TryParse(rizFactorRow.Cells[5].Value.ToString(), out double takhfif))
                    {
                        MessageBox.Show("برخی از مقادیر جدول نامعتبر هستند.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    await databaseHelper.AddRizFactorAsync(factorNumber, codeKala, tedad, takhfif);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ذخیره‌سازی فاکتور: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                savingForm.Close();
                this.Enabled = true;
                MessageBox.Show("فاکتور با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtTedad_TextChanged(object sender, EventArgs e)
        {
            string input = txtTedad.Text.Replace(".", "");

            if (decimal.TryParse(input, out decimal number))
            {
                txtTedad.Text = string.Format("{0:N0}", number).Replace(",", ".");

                txtTedad.SelectionStart = txtTedad.Text.Length;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string input = txtPrice.Text.Replace(".", "");

            if (decimal.TryParse(input, out decimal number))
            {
                txtPrice.Text = string.Format("{0:N0}", number).Replace(",", ".");

                txtPrice.SelectionStart = txtPrice.Text.Length;
            }
        }
    }
}
