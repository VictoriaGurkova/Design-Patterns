using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class MarathonStyle : IWritingDiploma
    {
        public void Write()
        {
            Console.WriteLine("Начинайте работу сейчас.\n" +
                "Требуется много силы воли.\n Уровень стресса: низкий.\n");
        }
    }
}
