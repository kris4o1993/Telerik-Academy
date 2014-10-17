namespace AdoDotNet
{
    using System;
    using System.Data.SqlClient;

    public class ProductsInCategories
    {
        public static void Main()
        {           
            var dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");

            dataBaseConnection.Open();
            using (dataBaseConnection)
            {
                //// 3. Write a program that retrieves from the Northwind database all product categories and the names of the products
                //// in each category. Can you do this with a single SQL query (with table join)?
                //// Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.

                var productCategoriesNameOfTheProducts = new SqlCommand(
                    "SELECT c.CategoryName, p.ProductName FROM Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID", dataBaseConnection);

                SqlDataReader reader = productCategoriesNameOfTheProducts.ExecuteReader();

                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    string categoryName = (string)reader["CategoryName"];
                    Console.WriteLine("{0} --- {1}", productName, categoryName);
                }
            }
        }
    }
}
