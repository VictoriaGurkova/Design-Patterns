using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FordBalk: Bulk
    {
        public override void CarryLoad()
        {
            Console.WriteLine("Кузов Ford укомплектован.");
        }
    }
}
