using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create a count of each character in a sample text
            string wallOfText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Dictionary<char, int> theCounts = new Dictionary<char, int>();
            List<string> affirmative = new List<string> { "yes", "y" };

            Console.WriteLine(wallOfText + "\n");

            // default text or user input?
            Console.WriteLine("Do you want to input text?");
            string userInput = Console.ReadLine();
            if (affirmative.Contains(userInput))
            {
                Console.WriteLine("Enter it now:");
                wallOfText = Console.ReadLine();
            }

            // case-insensitive?
            Console.WriteLine("Do you want this to be case-insensitive?");
            string caseInsensitive = Console.ReadLine();
            if (affirmative.Contains(caseInsensitive))
            {
                wallOfText = wallOfText.ToLower();
            }

            // only alphabetic characters?
            Console.WriteLine("Do you want only alphabetic characters?");
            string alphaOnly = Console.ReadLine();
            if (affirmative.Contains(alphaOnly))
            {
                wallOfText = new string(wallOfText.Where(c => Char.IsLetter(c)).ToArray());
            }

            // here is where the counting happens
            foreach (char letter in wallOfText)
            {
                if (theCounts.ContainsKey(letter))
                {
                    theCounts[letter]++;
                }
                else
                {
                    theCounts.Add(letter, 1);
                }
            }

            // print the resutls
            Console.WriteLine();
            int totalCount = 0;
            foreach (KeyValuePair<char, int> count in theCounts)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
                totalCount += count.Value;
            }
            Console.WriteLine("\nThe total character count is: " + totalCount);

            Console.ReadLine();
        }
    }
}
