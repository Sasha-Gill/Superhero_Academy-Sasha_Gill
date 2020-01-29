using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Student
    {
        public string Type;
        public string name;
        public int PhyAtk = 0;
        public int SpeAtk = 0;
        public int HP = 100;
        public int Spd = 0;
        public int PhyDef = 0;
        public int SpeDef = 0;

        public void WriteName(string name)
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Ok welcome "+name+" to Superhero Academy.");
        }
    }
}
