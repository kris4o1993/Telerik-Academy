namespace AdoDotNet
{
    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;

    public class RetrieveImages
    {
        private const int startPosition = 78;

        public static void Main()
        {
            var dataBaseConnection = new SqlConnection("Server=.\\SQLEXPRESS; " + "Database=Northwind; Integrated Security=true");

            dataBaseConnection.Open();
            using (dataBaseConnection)
            {
                //// 5. Write a program that retrieves the images for all categories in the Northwind database and stores them as 
                //// JPG files in the file system.

                var retrieveCategoryPictures = new SqlCommand("SELECT Picture, Description FROM Categories", dataBaseConnection);
                SqlDataReader reader = retrieveCategoryPictures.ExecuteReader();

                while (reader.Read())
                {
                    var picture = (byte[])reader["Picture"];
                    int pictureId = 1;

                    var memoryStream = new MemoryStream(picture, startPosition, picture.Length - startPosition);
                    using (Image image = Image.FromStream(memoryStream))
                    {
                        //// the pic is saved in the bin folder of the project
                        image.Save(pictureId + ".jpg");
                    }

                    pictureId++;
                }
            }
        }
    }
}