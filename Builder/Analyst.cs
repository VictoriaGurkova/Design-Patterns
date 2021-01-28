using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Analyst : Specialist
    {
        public override void DoWork()
        {
            Console.WriteLine("Составляю ТЗ и пишу документацию...");
        }

        public override void GetShedule()
        {
            Console.WriteLine("Работаю с понедельника по пятницу...");
        }

        public override void Rest()
        {
            Console.WriteLine("Покой мне только снится...");
        }
    }
}
