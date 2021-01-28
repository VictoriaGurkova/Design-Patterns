using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class StayerStyle : IWritingDiploma
    {
        public void Write()
        {
            Console.WriteLine("Начинайте работу не позднее, чем за полгода.\n" +
                "Требуется навыки жесткого планирования.\n Уровень стресса: средний.\n");
        }
    }
}
