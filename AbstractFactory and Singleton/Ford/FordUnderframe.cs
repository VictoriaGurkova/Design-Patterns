using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FordUnderframe: Underframe
    {
        public override void Control()
        {
            Console.WriteLine("Система управления Ford запущена.");
        }
    }
}
