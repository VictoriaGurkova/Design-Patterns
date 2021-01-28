using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ProjectManager
    {
        private Specialist specialist;
 
        public void Do()
        {
            specialist.GetShedule();
            specialist.DoWork();
            specialist.Rest();
        }

        public void SetSpecialist(Specialist specialist)
        {
            this.specialist = specialist;
        }
    }
}
