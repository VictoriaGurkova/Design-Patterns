using System;

namespace Flyweight
{
    class Client
    {
        static void Main(string[] args)
        {            
            string binding = "жесткий";
            string font = "моноширный";
            string paper = "офсетная";
            string cover = "с иллюстрацией";

            BooksFactory booksFactory = new BooksFactory();
            for (int i = 0; i < 2; i++)
            {
                Book harryPotter = booksFactory.GetBook("Гарри Поттер");
                if (harryPotter != null)
                    harryPotter.Produce(binding, font, paper, cover);
            }

            for (int i = 0; i < 2; i++)
            {
                Book theLord = booksFactory.GetBook("Властелин колец");
                if (theLord != null)
                    theLord.Produce(binding, font, paper, cover);
            }

            Console.Read();


        }
    }
}
