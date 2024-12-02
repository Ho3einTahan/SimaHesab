using System;
using System.Data;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace simaHesab.Classes
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper() => connectionString = Constants.Constants.ConnectionString;


        public async Task AddKalaAsync(string kalaName,int tedad,decimal price,decimal takhfif) {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "INSERT INTO Kala (Name, price, takhfif,Tedad) VALUES (@Name, @price, @takhfif,@Tedad)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", kalaName);
                    command.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value=price;
                    command.Parameters.AddWithValue("@takhfif", SqlDbType.Decimal).Value = takhfif;
                    command.Parameters.AddWithValue("@Tedad", tedad);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        // UPDATE kala price
        public async Task UpdateKalaPriceAsync(string kalaName, decimal newPrice)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = "UPDATE kala SET price = @Price WHERE kalaName = @KalaName";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KalaName", kalaName);
                command.Parameters.AddWithValue("@Price", newPrice);

                int rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Kala price updated successfully.");
                }
                else
                {
                    Console.WriteLine("No kala found with the given name.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // DELETE kala
        public async Task DeleteKalaAsync(string kalaName)
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = "DELETE FROM kala WHERE kalaName = @KalaName";
                using var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KalaName", kalaName);

                int rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Kala deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No kala found with the given name.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task DisplayAllKalaAsync()
        {
            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = "SELECT * FROM kala";
                using var command = new SqlCommand(query, connection);

                using var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Console.WriteLine($"Kala Name: {reader["kalaName"]}, Price: {reader["price"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task<DataTable> GetAllKalaAsync(string query)
        {
            var dataTable = new DataTable();

            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                using var adapter = new SqlDataAdapter(query, connection);

                await Task.Run(() => adapter.Fill(dataTable));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return dataTable;
        }

        public async Task<DataTable> GetAllFactorAsync()
        {
            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            string query = "SELECT *, (SELECT SUM(factorPrice) FROM factor) AS totalPrice FROM factor";

            using var command = new SqlCommand(query, connection);

            using var reader = await command.ExecuteReaderAsync();

            DataTable dataTable = await Task.Run(() =>
            {
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            });

            return dataTable;
        }


        public async Task<DataTable> GetFactorByDate(string startDate, string endDate,int factorNumber)
        {
            SqlCommand command;

            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = "";

                if (factorNumber > 0)
                {

                    query = @"
                       SELECT *, 
                              (SELECT SUM(factorPrice) FROM factor WHERE codeFactor = @codeFactor) AS totalPrice
                              FROM factor
                              WHERE codeFactor = @codeFactor";

                    command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@codeFactor", factorNumber);
                }
                else {
                    query = @"
                       SELECT *, 
                              (SELECT SUM(factorPrice) FROM factor WHERE saveDate >= @startDate AND saveDate <= @endDate) AS totalPrice
                              FROM factor
                              WHERE saveDate >= @startDate AND saveDate <= @endDate";

                    command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);
                }

                using var reader = await command.ExecuteReaderAsync();

                DataTable dataTable = await Task.Run(() =>
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                });

                return dataTable;

            }
            catch (Exception ex)
            {   
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

        }


        public async Task<int> GetMaxCodeFactorAsync()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT MAX(codeFactor) FROM Factor";

                using (var command = new SqlCommand(query, connection))
                {
                    var result = await command.ExecuteScalarAsync();
                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        return 1;
                    }

                }
            }
        }


        public async Task AddNewFactorAsync(string date, decimal factorPrice, string sharh)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "INSERT INTO Factor (date, factorPrice, sharh) VALUES (@date, @factorPrice, @sharh)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@factorPrice", SqlDbType.Decimal).Value= factorPrice;
                    command.Parameters.AddWithValue("@sharh", sharh);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task AddRizFactorAsync(int factorCode, int kalaCode, double tedad, double takhfif)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "INSERT INTO RizFactor (codeFactor, CodeKala, tedad, takhfif) VALUES (@codeFactor, @CodeKala, @tedad, @takhfif)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@codeFactor", factorCode);
                    command.Parameters.AddWithValue("@CodeKala", kalaCode);
                    command.Parameters.AddWithValue("@tedad", tedad);
                    command.Parameters.AddWithValue("@takhfif", takhfif);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

    }
}
