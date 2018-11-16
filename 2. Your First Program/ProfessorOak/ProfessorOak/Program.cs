using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorOak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            Console.WriteLine("I’m Professor Oak.");
            Console.WriteLine("What is your name ?");

            var yourName = Console.ReadLine();

            Console.WriteLine("Oh, your name is " + yourName);

            if (yourName == "Ash")
            {
                Console.WriteLine("Here is your Pikachu.");
            }
            else
            {
                Console.WriteLine("Here is your Charmander");
            }
        }
    }
}
