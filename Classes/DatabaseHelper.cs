using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace simaHesab
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            this.connectionString = Constants.ConnectionString;
        }

        // به‌روزرسانی قیمت کالا
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

        public async Task<DataTable> GetAllKalaAsync()
        {
            var dataTable = new DataTable();

            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = "SELECT * FROM kala";
                using var adapter = new SqlDataAdapter(query, connection);

                await Task.Run(() => adapter.Fill(dataTable));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return dataTable;
        }

        public async Task<DataTable> GetAllFactor() {

            var dataTable = new DataTable();

            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = "SELECT *,(SELECT SUM(factorPrice) FROM factor) AS totalPrice FROM factor";

                using var adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);

                await Task.Run(() => adapter.Fill(dataTable));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return dataTable;

        }


        public async Task<DataTable> GetFactorByDate(string startDate, string endDate)
        {
            var dataTable = new DataTable();

            try
            {
                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();

                string query = @"
                       SELECT *, 
                              (SELECT SUM(factorPrice) FROM factor WHERE saveDate >= @startDate AND saveDate <= @endDate) AS totalPrice
                              FROM factor
                              WHERE saveDate >= @startDate AND saveDate <= @endDate";
            
                using var command = new SqlCommand(query, connection);

                // اضافه کردن پارامترهای تاریخ
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

                using var adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return dataTable;
        }


    }
}
