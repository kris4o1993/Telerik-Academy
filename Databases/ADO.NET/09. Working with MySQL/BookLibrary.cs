namespace DatabaseConnections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        private readonly Book[] books =
    {
        new Book()
        {
            Title = "Harry Potter",
            Author = "J.K. Rowling",
            PublishDate = new DateTime(2013, 10, 22),
            ISBN = "4123583259"
        },
        new Book()
        {
            Title = "FakeBook #1",
            Author = "Fake Author #1",
            PublishDate = new DateTime(2000, 10, 10),
            ISBN = "135324223"
        },
        new Book()
        {
            Title = "The Green Mile",
            Author = "Stephen King",
            PublishDate = new DateTime(2013, 12, 17),
            ISBN = "502358234"
        },
        new Book()
        {
            Title = "FakeBook #2",
            Author = "Fake Author #2",
            PublishDate = new DateTime(2012, 5, 17),
            ISBN = "78423785723"
        }
    };

        public ICollection<Book> Books
        {
            get { return this.books.ToList(); }
        }
    }
}