using System;

namespace Builder
{
    class Client
    {
        static void Main(string[] args)
        {
            ProjectManager projectManager = new ProjectManager();

            projectManager.SetSpecialist(new FrontendProgrammer());
            projectManager.Do();
            Console.WriteLine("...................................");

            projectManager.SetSpecialist(new BackendProgrammer());
            projectManager.Do();
            Console.WriteLine("...................................");

            projectManager.SetSpecialist(new Analyst());
            projectManager.Do();
            Console.WriteLine("...................................");


        }
    }
}
