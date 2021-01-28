using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FordMotor: Motor
    {
        public override void StartMotor()
        {
            Console.WriteLine("Двигатель Ford запущен.");
        }
        public override void PutInMotion()
        {
            Console.WriteLine("Машина Ford начала движение.");
        }
    }
}
