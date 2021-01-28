using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FordFactory: CarFactory
    {
        public override Motor CreateMotor()
        {
            FordMotor motor = new FordMotor();
            Console.WriteLine("Создан мотор Ford!");
            return motor;
        }

        public override Underframe CreateUnderframe()
        {
            FordUnderframe underframe = new FordUnderframe();
            Console.WriteLine("Создано шасси Ford!");
            return underframe;
        }

        public override Bulk CreateBulk()
        {
            FordBalk balk = new FordBalk();
            Console.WriteLine("Создан кузов Ford!");
            return balk;
        }
    }
}
