using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ToyotaFactory: CarFactory
    {
        public override Motor CreateMotor()
        {
            ToyotaMotor motor = new ToyotaMotor();
            Console.WriteLine("Создан мотор Toyota!");
            return motor;
        }

        public override Underframe CreateUnderframe()
        {
            ToyotaUnderframe underframe = new ToyotaUnderframe();
            Console.WriteLine("Создано шасси Toyota!");
            return underframe;
        }

        public override Bulk CreateBulk()
        {
            ToyotaBalk balk = new ToyotaBalk();
            Console.WriteLine("Создан кузов Toyota!");
            return balk;
        }
    }
}
