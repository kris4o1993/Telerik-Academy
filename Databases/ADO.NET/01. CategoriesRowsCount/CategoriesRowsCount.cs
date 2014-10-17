namespace AdoDotNet
{
    using System;
    using System.Data.SqlClient;

    public class CategoriesRowsCount
    {
        public static void Main()
        {
            var dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");

            dataBaseConnection.Open();
            using (dataBaseConnection)
            {
                //// 1. Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the
                //// Categories table.

                var allCategories = new SqlCommand("SELECT COUNT(*) FROM Categories", dataBaseConnection);
                int categoriesCount = (int)allCategories.ExecuteScalar();
                Console.WriteLine("Categories count: {0} ", categoriesCount);
            }
        }
    }
}
