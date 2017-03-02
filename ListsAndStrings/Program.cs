using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsAndStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Write a static method to print out each word in a list that has exactly 5 letters

            // declare varaibles
            List<string> myList = new List<string> { "hello", "my", "name", "is", "Jeremy", "cinco" };
            List<string> cincoList = new List<string>();

            // write out starting list
            foreach (string item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(".");

            // find and write only 5 letter words from list
            foreach (string item in myList)
            {
                if (findNeedle(item) == true)
                {
                    cincoList.Add(item);
                }
            }

            foreach (string item in cincoList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        public static bool findNeedle(string needle)
        {
            // return true if string is 5 chars long
            if (needle.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
