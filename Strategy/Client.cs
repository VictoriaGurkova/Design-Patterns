using System;

namespace Strategy
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кто вы?");
            string person = Console.ReadLine();
            Console.WriteLine("Cколько у вас времени до дедлайна?");
            string availableTime = Console.ReadLine();

            if(person == "студент")
            {
                Student student = new Student();
                switch (availableTime)
                {
                    case "много":
                        student.SetWritingDiploma(new MarathonStyle());
                        student.Write();
                        break;
                    case "достаточно":
                        student.SetWritingDiploma(new StayerStyle());
                        student.Write();
                        break;
                    case "мало":
                        student.SetWritingDiploma(new SprintStyle());
                        student.Write();
                        break;
                }
            }
            else if(person == "работник")
            {
                Worker worker = new Worker();
                switch (availableTime)
                {
                    case "много":
                        worker.SetWritingDiploma(new MarathonStyle());
                        worker.Write();
                        break;
                    case "достаточно":
                        worker.SetWritingDiploma(new StayerStyle());
                        worker.Write();
                        break;
                    case "мало":
                        worker.SetWritingDiploma(new SprintStyle());
                        worker.Write();
                        break;
                }
            }
            Console.ReadLine();
            
        }
    }
}
