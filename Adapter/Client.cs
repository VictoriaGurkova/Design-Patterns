using System;

namespace Adapter
{
    class Client
    {
        static void Main(string[] args)
        {
            ServerInterface server = new Adapter();
            Console.WriteLine("Получаем от сервера температуру по шкале Фаренгейта и с помощью адаптера " +
                "переводим в градусы Цельсия.");

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Температура в Цельсиях от адаптера: {0}\n", server.GetTemperature());
            }
        }
    }
}
