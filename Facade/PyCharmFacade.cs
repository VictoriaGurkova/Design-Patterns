using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class PyCharmFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        PVM pvm;

        public PyCharmFacade(TextEditor textEditor, Compiller compiller, PVM pvm)
        {
            this.textEditor = textEditor;
            this.compiller = compiller;
            this.pvm = pvm;
        }

        public void Start()
        {
            textEditor.CreateScript();
            textEditor.SaveScript();
            compiller.Compile();
            compiller.CreatePycFile();
            pvm.Execute();
        }

        public void Stop()
        {
            pvm.GetResult();
        }
    }
}
