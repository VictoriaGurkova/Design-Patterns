using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ToyotaMotor: Motor
    {
        public override void StartMotor()
        {
            Console.WriteLine("Двигатель Toyota запущен.");
        }

        public override void PutInMotion()
        {
            Console.WriteLine("Машина Toyota начала движение.");
        }
    }
}
