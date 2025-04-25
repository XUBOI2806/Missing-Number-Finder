using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Missing_Number_Finder.Interfaces;

namespace Missing_Number_Finder.Services
{
    public class ConsoleActions : IConsoleActions
    {
        // Retrieves the input from the user
        public int[] GetUserInput()
        {
            Console.WriteLine("Enter array: ");
            string input = Console.ReadLine();

            if (input == "[]")
            {
                return new int[0];
            }

            int[] numList = input.Trim('[', ']').Split(',').Select(int.Parse).ToArray();
            return numList;
        }
    }
}
