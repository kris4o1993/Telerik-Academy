namespace AdoDotNet
{
    using System;
    using System.Data.SqlClient;

    public class FindSubString
    {
        public static void Main()
        { 
            //// 8. Write a program that reads a string from the console and finds all products that contain this string.
            //// Ensure you handle correctly characters like ', %, ", \ and _.
            Console.Write("Enter a search string: ");
            var pattern = Console.ReadLine();
            
            var dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");
                  
            dataBaseConnection.Open();
            var sqlCommand = new SqlCommand(@"SELECT ProductName
                                                 FROM Products
                                                 WHERE CHARINDEX(@pattern, ProductName) > 0", dataBaseConnection);

            sqlCommand.Parameters.AddWithValue("@pattern", pattern);

            using (dataBaseConnection)
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productName = reader["ProductName"];

                        Console.WriteLine(" --- " + productName);
                    }
                }
            }
        }
    }
}