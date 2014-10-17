namespace AdoDotNet
{
    using System;
    using System.Data.SqlClient;

    public class InsertProductMethod
    {
        private static SqlConnection dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");

        public static void Main()
        {
            //// 4. Write a method that adds a new product in the products table in the Northwind database. Use a parameterized SQL command.

            dataBaseConnection.Open();
            using (dataBaseConnection)
            {
                InsertProduct("Kapi", 5, 5, "1 Kasa KapiX24", 2.00M, 100, 1000, 43, 0);
            }
        }

        public static void InsertProduct(string productName, int supplierId, int categoryId, string quantityPerUnit, decimal unitPrice,
    int unitsInstock, int unitsOnOrder, int reorderLevel, int discontinued)
        {
            var command = new SqlCommand("INSERT INTO Products " +
              "(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES " +
              "(@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, @unitsInstock, @unitsOnOrder, @reorderLevel, @discontinued)", dataBaseConnection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@supplierId", supplierId);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            command.Parameters.AddWithValue("@unitPrice", unitPrice);
            command.Parameters.AddWithValue("@unitsInstock", unitsInstock);
            command.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            command.Parameters.AddWithValue("@discontinued", discontinued);
            command.ExecuteNonQuery();
        }
    }
}
