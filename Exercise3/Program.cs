using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            Console.WriteLine("How many miles did you drive?");
            miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons did you use?");
            gallons = double.Parse(Console.ReadLine());
            mpg = miles / gallons;
            Console.WriteLine("Your MPG is " + mpg.ToString() + ".");
            Console.ReadLine();

        }
    }
}
