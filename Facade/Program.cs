using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            PVM pvm = new PVM();

            PyCharmFacade pyCharm = new PyCharmFacade(textEditor, compiller, pvm);

            Programmer programmer = new Programmer();
            programmer.CreatePythonApp(pyCharm);

            Console.Read();
        }
    }
}
