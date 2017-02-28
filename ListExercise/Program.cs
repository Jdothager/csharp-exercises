using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> myList = new List<int> {1, 2, 3, 4, 5, 6};
            double sum = 0;

            foreach (int i in myList)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The starting string is: " + String.Join(", ", myList));

            Console.WriteLine("The sum of all the even numbers in the list is: " + sum);
            Console.ReadLine();
        }
    }
}
