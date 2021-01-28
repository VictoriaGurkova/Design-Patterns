using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Server: ServerInterface
    {
        public Server()
        {
            Console.WriteLine("Подключение к серверу...");
        }

        public double GetTemperature()
        {
            Random random = new Random();
            double temp = random.Next(32, 212);
            Console.WriteLine("Температура в Фаренгейтах от сервера: {0}", temp);
            return temp;
        }
    }
}
