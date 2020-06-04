using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string suess = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] arr = suess.Split(".");
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
