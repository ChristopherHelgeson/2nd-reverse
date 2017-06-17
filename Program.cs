using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string userInput = String.Empty;
            string reverseString = String.Empty;

            //get string from user
            Console.Clear();
            Console.WriteLine("Program to Reverse the Characters of Any String");
            Console.WriteLine();
            Console.WriteLine("Type anything you want: ");
            userInput = Console.ReadLine();

            //make sure input is an integer

            Console.WriteLine("\nYou entered " + userInput);
            reverseString = ReverseString(userInput);
            Console.WriteLine("\nYour string in reverse order is: " + reverseString);
            Console.WriteLine("\nPress any key to continue . . .");
            string pauseTime = Console.ReadLine();

        }
        public static string ReverseString(string userInput)
        //reverse string
        {
            int a = userInput.Length;
            int b = a;
            Console.WriteLine("\nYour string has " + a + " characters.");
            string buildReverse = String.Empty;
            while (a != 0)
            {
                string firstChar = userInput.Substring((b-a), 1);
                buildReverse = firstChar + buildReverse;
                a--;
            }
            return buildReverse;
        }
    }
}
