using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Compiller
    {
        public void Compile()
        {
            Console.WriteLine("Компиляция исходного текста сценария а байт-код...");
        }

        public void CreatePycFile()
        {
            Console.WriteLine("Создание файла с расширением .pyc...\n");
        }
    }
}
