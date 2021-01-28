using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ToyotaBalk: Bulk
    {
        public override void CarryLoad()
        {
            Console.WriteLine("Кузов Toyota укомплектован.");
        }
    }
}
