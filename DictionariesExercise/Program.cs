using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace DictionariesExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create a dicionary that uses studentID as the key and returns studentName as value

            // variables
            string studentName;
            int studentID;
            Dictionary<int, string> schoolDict = new Dictionary<int, string>();

            // get student info
            Console.WriteLine("Enter the students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                studentName = Console.ReadLine();
                if (studentName != "")
                {
                    Console.Write("ID number: ");
                    studentID = int.Parse(Console.ReadLine());

                    schoolDict.Add(studentID, studentName);
                }
            }
            while (studentName != "");

            /*

            // print dictionary
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in schoolDict)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            */

            // print dictionary using stringbuilder
            Console.WriteLine("\nClass roster: ");
            StringBuilder myStringBuilder = new StringBuilder();
            foreach (KeyValuePair<int, string> student in schoolDict)
            {
                myStringBuilder.Append("name: " + student.Value + " key: " + student.Key + "\n");
            }
            Console.WriteLine(myStringBuilder);

            Console.ReadLine();
        }
    }
}
