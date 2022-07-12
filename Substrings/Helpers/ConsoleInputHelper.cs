using System;
using Substrings.Interfaces;

namespace Substrings.Helpers
{
    /// <summary>
    /// Helps to get strings array with console
    /// </summary>
    public class ConsoleInputHelper : IInputHelper
    {
        public string[] GetStringsArray()
        {
            int stringsAmount = GetStringAmount();
            string[] strArray = new string[stringsAmount];

            for (int i = 0; i < stringsAmount; i++)
            {
                Console.WriteLine($"Enter the {i} string: ");
                string? tempString = Console.ReadLine();

                // Check for correct input
                if (String.IsNullOrEmpty(tempString))
                {
                    continue;
                }

                strArray[i] = tempString;
            }

            return strArray;
        }

        private static int GetStringAmount()
        {
            // Get the amount of the strings in array
            string? strNum;
            Console.WriteLine("Enter the amount of strings: ");
            strNum = Console.ReadLine();

            // If user entered a number
            if (int.TryParse(strNum, out int num))
            {
                return num;
            }

            // If user entered not a number
            Console.WriteLine("Wrong input, try again.");
            return GetStringAmount();
        }
    }
}

