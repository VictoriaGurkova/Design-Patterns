using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class TheLordOfTheRings : Book
    {
        public TheLordOfTheRings()
        {
            name = "Властелин колец: Братство кольца";
            author = "Джон Толкин";
        }

        public override void Produce(string binding, string font, string paper, string cover)
        {
            Console.WriteLine("Издана книга Джона Толкина <Властелин колец: Братство кольца>!\n" +
                "Переплет: {0};\n Шрифт: {1};\n Бумага: {2};\n Обложка: {3}.\n", binding, font, paper, cover);
        }
    }
}
