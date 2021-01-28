using System;

namespace Decorator
{
    class Client
    {
        static void Main(string[] args)
        {
            Burger cheesburger1 = new CheeseBurger();
            cheesburger1 = new DoubleBurger(cheesburger1); 
            Console.WriteLine("Название: {0}", cheesburger1.Name);
            Console.WriteLine("Цена: {0} \n", cheesburger1.GetCost());

            Burger cheesburger2 = new CheeseBurger();
            cheesburger2 = new TripleBurger(cheesburger2);
            Console.WriteLine("Название: {0}", cheesburger2.Name);
            Console.WriteLine("Цена: {0} \n", cheesburger2.GetCost());

            Burger cheesburger3 = new CheeseBurger();
            cheesburger3 = new BaconBurger(cheesburger3);
            Console.WriteLine("Название: {0}", cheesburger3.Name);
            Console.WriteLine("Цена: {0} \n", cheesburger3.GetCost());

            Burger bigtasty1 = new BigTasty();
            bigtasty1 = new DoubleBurger(bigtasty1);
            Console.WriteLine("Название: {0}", bigtasty1.Name);
            Console.WriteLine("Цена: {0} \n", bigtasty1.GetCost());

            Burger bigtasty2 = new BigTasty();
            bigtasty2 = new TripleBurger(bigtasty2);
            Console.WriteLine("Название: {0}", bigtasty2.Name);
            Console.WriteLine("Цена: {0} \n", bigtasty2.GetCost());

            Burger bigtasty3 = new BigTasty();
            bigtasty3 = new BaconBurger(bigtasty3);
            Console.WriteLine("Название: {0}", bigtasty3.Name);
            Console.WriteLine("Цена: {0} \n", bigtasty3.GetCost());

            Console.ReadLine();
        }
    }
}
