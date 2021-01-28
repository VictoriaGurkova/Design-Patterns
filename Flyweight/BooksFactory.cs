using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class BooksFactory
    {
        Dictionary<string, Book> books = new Dictionary<string, Book>();
        public BooksFactory()
        {
            books.Add("Гарри Поттер", new HarryPotter());
            books.Add("Властелин колец", new TheLordOfTheRings());
        }

        public Book GetBook(string key)
        {
            if (books.ContainsKey(key))
                return books[key];
            else
                return null;
        }
    }
}
