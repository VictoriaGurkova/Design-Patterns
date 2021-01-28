using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class HarryPotter : Book
    {
        public HarryPotter()
        {
            name = "Гарри Поттер и философский камень";
            author = "Джоан Роулинг";
        }

        public override void Produce(string binding, string font, string paper, string cover)
        {
            Console.WriteLine("Издана книга Джоан Роулинг <Гарри Поттер и философский камень>!\n" +
                "Переплет: {0};\n Шрифт: {1};\n Бумага: {2};\n Обложка: {3}.\n", binding, font, paper, cover);
        }
    }
}
