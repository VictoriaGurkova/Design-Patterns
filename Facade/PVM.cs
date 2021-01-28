using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class PVM
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение инструкций из файла .pyc...");
        }

        public void GetResult()
        {
            Console.WriteLine("Получение результата выполнения сценария...");
        }
    }
}
