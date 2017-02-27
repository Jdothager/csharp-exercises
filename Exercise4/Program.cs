using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static bool Search(string haystack, string needle)
        {
            // search for needle, print result
            if (haystack.IndexOf(needle) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // declare variables
            string haystack = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string needle;
            bool result;

            // get the needle from user
            Console.WriteLine("Whatcha looking fur, Bub?");
            needle = Console.ReadLine();

            // make the needle and haystack case-insensitive and remove whitespace from needle
            haystack = haystack.ToLower();
            needle = needle.ToLower();
            needle = needle.Trim();

            // call Search and display results
            result = Search(haystack, needle);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
