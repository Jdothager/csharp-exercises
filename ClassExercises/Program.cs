using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double width;
            double area;

            Console.WriteLine("Human, since you can't math, I will help you figure out the area of a rectangle.");
            Console.WriteLine("What is the height?");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width?");
            width = double.Parse(Console.ReadLine());
            area = height * width;
            Console.WriteLine("The area of this rectangle is: " + area.ToString());
            Console.ReadLine();
        }
    }
}
