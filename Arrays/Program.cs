using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create and initialize an array, then loop through the array and print out each value.
            int[] myArray = new int[] { 1, 1, 2, 3, 5, 8 };

            // loop and print
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
