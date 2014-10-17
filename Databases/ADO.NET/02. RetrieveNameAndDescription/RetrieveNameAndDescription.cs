namespace AdoDotNet
{
    using System;
    using System.Data.SqlClient;

    public class RetrieveNameAndDescription
    {
        public static void Main()
        {
            var dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");

            dataBaseConnection.Open();
            using (dataBaseConnection)
            {
                //// 2. Write a program that retrieves the name and description of all categories in the Northwind DB.

                var categoriesNameAndDescription = new SqlCommand("SELECT CategoryName, Description FROM Categories", dataBaseConnection);
                SqlDataReader reader = categoriesNameAndDescription.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} --- Description: {1}", categoryName, description);
                }
            }
        }
    }
}
