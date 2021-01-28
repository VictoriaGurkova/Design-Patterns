using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SprintStyle : IWritingDiploma
    {
        public void Write()
        {
            Console.WriteLine("Начинайте работу не позднее, чем за 2 месяца.\n" +
                "Требуется высокая стрессоустойчивость.\n Уровень стресса: высокий.\n");
        }
    }
}
