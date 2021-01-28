using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Programmer
    {
        public void CreatePythonApp(PyCharmFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
