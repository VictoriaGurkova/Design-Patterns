using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class FrontendProgrammer : Specialist
    {
        public override void DoWork()
        {
            Console.WriteLine("Верстаю шаблон сайта...");
        }

        public override void GetShedule()
        {
            Console.WriteLine("У меня свободный график...");
        }

        public override void Rest()
        {
            Console.WriteLine("Когда отдыхаю, смотрю сериалы...");
        }
    }
}
