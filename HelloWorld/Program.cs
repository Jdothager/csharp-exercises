using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Greetings human!  What is your name?");
            input = Console.ReadLine();
            Console.WriteLine("It is very nice to meet you, " + input + ".");
            Console.ReadLine();

            // Console.WriteLine("Hello World!");
            // Console.ReadLine();

        }
    }
}
