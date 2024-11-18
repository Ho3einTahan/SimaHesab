namespace simaHesab.Constants
{
    public static class Constants
    {
        // Connection string
        public static readonly string ConnectionString = "Server=.\\pooyesh;Database=SimaHesab;User Id=sa;Password=PSC@560;TrustServerCertificate=True;";

        // Table names
        public static class Tables
        {
            public const string Kala = "kala";
            public const string Invoices = "Invoices";
        }

        // Column names for Kala table
        public static class KalaColumns
        {
            public const string KalaId = "kalaId";
            public const string KalaName = "kalaName";
            public const string Price = "price";
            public const string Barcode = "barcode";
            public const string Quantity = "tedad";
            public const string Discount = "takhfif";
            public const string SaveDate = "saveDate";
        }

        // Column names for Invoices table
        public static class InvoiceColumns
        {
            public const string Id = "id";
            public const string FactorNumber = "factorNumber";
            public const string FactorPrice = "factorPrice";
            public const string ReceivePrice = "receivePrice";
            public const string Status = "status";
            public const string Description = "description";
            public const string SaveDate = "saveDate";
        }
    }
}
