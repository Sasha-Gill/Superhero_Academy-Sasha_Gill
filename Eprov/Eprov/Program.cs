using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperStrenght StrongStudent = new SuperStrenght();
            Tank TankStudent = new Tank();
            Cyborg CyborgStudent = new Cyborg();
            Student student = new Student();

            string AnswerType;

            Console.WriteLine("What type of superhero student are you?");
            Console.WriteLine("A: Super Strenght");
            Console.WriteLine("B: Tank");
            Console.WriteLine("C: Cyborg");
            Console.ReadLine();

            while(AnswerType = "A"|"B"|"C")
            {
                if (AnswerType == "A")
                {
                    StrongStudent.WriteName();
                }
            }
        }
    }
}
