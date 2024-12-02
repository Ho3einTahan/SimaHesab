using simaHesab.Classes;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace simaHesab
{
    public partial class SodoorFactor : Form
    {

        private DatabaseHelper databaseHelper;
        private PrintDocument printDocument;

        public SodoorFactor()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
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
                double takhfif = double.Parse(txtPrice.Text.Replace(".", "")) * double.Parse(txtTakhfif.Text.Replace(".", "")) / 100;
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
                        rows.Count,
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

            txtFactorNumber.Text = (await databaseHelper.GetMaxCodeFactorAsync()).ToString();

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

            if (dataGridFactor.Rows[0].Cells[1].Value == null || dataGridFactor.Rows[0].Cells[1].Value == "")
            {
                MessageBox.Show("فاکتور نمی‌تواند خالی باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("تاریخ نمی‌تواند خالی باشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                totalPrice = Math.Round(totalPrice, 2);

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

                    await databaseHelper.AddRizFactorAsync(int.Parse(txtFactorNumber.Text), codeKala, tedad, takhfif);

                    savingForm.Close();
                    MessageBox.Show("فاکتور با موفقیت ثبت شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                savingForm.Close();
                this.Enabled = true;
                MessageBox.Show($"خطا در ذخیره‌سازی فاکتور: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCodeKala.Clear();
            txtKalaName.Clear();
            txtTedad.Clear();
            txtPrice.Clear();
            txtTakhfif.Clear();
        }

        private void dataGridFactor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && !dataGridFactor.CurrentRow.IsNewRow)
            {
                DialogResult result = MessageBox.Show("آیا قصد حذف این کالا را دارید ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var rows = dataGridFactor.Rows;
                    int index = dataGridFactor.CurrentRow.Index;
                    rows.RemoveAt(index);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // باز کردن دیالوگ چاپ
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // بررسی اینکه کاربر دیالوگ چاپ را تایید کرده باشد
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // انجام چاپ
                printDocument.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // تعریف فونت‌ها و رنگ‌ها
            Font titleFont = new Font("B Nazanin", 16, FontStyle.Bold);
            Font regularFont = new Font("B Nazanin", 12);
            Font headerFont = new Font("B Nazanin", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

            float x = 50;
            float y = 50;

            // چاپ نام فروشگاه
            e.Graphics.DrawString("فروشگاه نمونه", titleFont, brush, x, y);
            y += 30;

            // چاپ تاریخ و شرح فاکتور
            e.Graphics.DrawString($"تاریخ:", regularFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"شرح: ", regularFont, brush, x, y);
            y += 30;

            // چاپ جدول اقلام فاکتور
            e.Graphics.DrawString("نام کالا", headerFont, brush, x, y);
            e.Graphics.DrawString("تعداد", headerFont, brush, x + 200, y);
            e.Graphics.DrawString("قیمت واحد", headerFont, brush, x + 300, y);
            e.Graphics.DrawString("تخفیف", headerFont, brush, x + 400, y);
            e.Graphics.DrawString("قیمت کل", headerFont, brush, x + 500, y);
            y += 30;

            List<FactorItem> items = [] ;

            foreach (DataGridViewRow row in dataGridFactor.Rows)
            {
                if (row.IsNewRow) continue;

                // خواندن مقادیر هر ردیف
                var name = row.Cells[0].Value.ToString();
                var quantity = Convert.ToString(row.Cells[1].Value);
                var price = Convert.ToString(row.Cells[2].Value);
                var discount = Convert.ToString(row.Cells[3].Value);

                // افزودن به لیست اقلام
                items.Add(new FactorItem { Name = name, Quantity = 2, UnitPrice = 3, Discount = 12, Total = 32 });
            }

            foreach (var item in items)
            {
                // چاپ مقادیر هر ردیف
                e.Graphics.DrawString(item.Name, regularFont, brush, x, y);
                e.Graphics.DrawString(item.Quantity.ToString(), regularFont, brush, x + 200, y);
                e.Graphics.DrawString(item.UnitPrice.ToString("C"), regularFont, brush, x + 300, y);
                e.Graphics.DrawString(item.Discount.ToString("C"), regularFont, brush, x + 400, y);
                e.Graphics.DrawString(item.Total.ToString("C"), regularFont, brush, x + 500, y);
                y += 20;
            }

            // چاپ مجموع قیمت
            y += 20;
            e.Graphics.DrawString($"مجموع: {totalPrice.ToString()}", headerFont, brush, x, y);
        }

        public class FactorItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Discount { get; set; }
            public decimal Total { get; set; }
        }

    }
}