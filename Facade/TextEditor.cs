using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class TextEditor
    {
      public void CreateScript()
        {
            Console.WriteLine("Написание текста сценария...");
        }

      public void SaveScript()
        {
            Console.WriteLine("Сохранение текста сценария...\n");
        }
    }
}
