﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov
{
    class Tank: Student

    {
        string Type = "Tank";
        string Name;

        void WriteName(string name)
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Ok welcome " + name + " to Superhero Academy.");
        }

    }

}
