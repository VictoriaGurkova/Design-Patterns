using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Student
    {
        public Student()
        {

        }

        public IWritingDiploma writingDiploma { private get; set; }
        public void Write()
        {
            writingDiploma.Write();
        }

        public void SetWritingDiploma(IWritingDiploma wrt)
        {
            this.writingDiploma = wrt;
        }
    }
}
