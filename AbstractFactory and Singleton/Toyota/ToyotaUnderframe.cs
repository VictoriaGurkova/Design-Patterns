using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ToyotaUnderframe: Underframe
    {
        public override void Control()
        {
            Console.WriteLine("Система управления Toyota запущена.");
        }
    }
}
