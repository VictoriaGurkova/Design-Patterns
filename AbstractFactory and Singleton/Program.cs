using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Controller controller = Controller.GetController();

            FordFactory ford = new FordFactory();
            controller.SetCarFactory(ford);
            controller.CreateAndMoveCar();

            Console.WriteLine();

            ToyotaFactory toyota = new ToyotaFactory();
            controller.SetCarFactory(toyota);
            controller.CreateAndMoveCar();
        }
    }
}
