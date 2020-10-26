using System;
using System.Collections.Generic;

namespace FinalHandsOn8
{
    class Program
    {
        static void Main(string[] args)
        {
            var userStrings = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a string. Enter an empty string to exit");
                string userInput = Console.ReadLine();
                if (userInput.Length == 0)
                {
                    break;
                }
                else
                {
                    userStrings.Add(userInput);
                }
            }
            string longestString = userStrings[0];
            string shorteststring = userStrings[0];
            userStrings.Sort();
            string earliestString = userStrings[0];
            string latestString = userStrings[userStrings.Count-1];
            foreach (var item in userStrings)
            {
                if (item.Length > longestString.Length)
                {
                    longestString = item;
                }
                if (item.Length < shorteststring.Length)
                {
                    shorteststring = item;
                }
            }
            Console.WriteLine("The longest string is: " + longestString);
            Console.WriteLine("The shortest string is: " + shorteststring);
            Console.WriteLine("The earliest string is: " + earliestString);
            Console.WriteLine("The latest string is: " + latestString);
        }
    }
}
