using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"Sum of even numbers in the list is : {Lister(myList)}");

            string suess = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            List<string> converter = suess.Split(" ").ToList();

            foreach (string i in converter)
            {
                Console.WriteLine(i);
            }
        }

        static int Lister(List<int> args)
        {
            int sum = 0;

            foreach (int num in args)
            {
                if(num%2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
