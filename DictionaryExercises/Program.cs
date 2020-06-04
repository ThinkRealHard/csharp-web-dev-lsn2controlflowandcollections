using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students' names and IDs (or Enter to finish).");

            do
            {
                Console.Write("Student Name: ");
                newStudent = Console.ReadLine();

                if (newStudent != "")
                {
                    Console.Write("ID Number: ");
                    int newID = Int32.Parse(Console.ReadLine());

                    students.Add(newStudent, newID);
                }
            } while (newStudent != "");

            Console.WriteLine("\nThe class list: ");

            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine($"{student.Key}'s ID: {student.Value}");
            }


        }
    }
}
