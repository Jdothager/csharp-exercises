﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double radius;
            double area;
            string result;

            // get user input for radius
            Console.WriteLine("What is the radius of your circle?");
            radius = float.Parse(Console.ReadLine());

            // calculate area
            area = 3.14 * radius * radius;

            // return result
            result = String.Format("The area of your circle is: {0}", area);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
