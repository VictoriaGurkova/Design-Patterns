using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BackendProgrammer : Specialist
    {
        public override void DoWork()
        {
            Console.WriteLine("Разрабатываю серверную часть приложения...");
        }

        public override void GetShedule()
        {
            Console.WriteLine("Работаю только по ночам...");
        }

        public override void Rest()
        {
            Console.WriteLine("Когда отдыхаю, играю в настольные игры...");
        }
    }
}
