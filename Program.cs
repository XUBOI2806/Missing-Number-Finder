/*
In C# create a console app that finds the Missing Number using SOLID principles
Description: Given an array containing numbers taken from the range 0 to n, find the one number that is missing from the array.

Input:
An array of integers number where nums contains n distinct numbers from the range 0 to n.

Output:
Return the missing number.

Examples:
Input: [3, 0, 1]
Output: 2

Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]
Output: 8
*/

namespace MissingNumberFinderApp
{
    public class ConsoleActions
    {
        // Retrieves the input from the user
        public int[] GetUserInput()
        {
            Console.WriteLine("Enter array: ");
            string input = Console.ReadLine();
            int[] numList = input.Trim('[', ']').Split(',').Select(int.Parse).ToArray();
            return numList;
        }
    }

    public class MissingNumberFinder
    {
        // Finds the missing number by finding the length of the list, then finding the added total and deducting that with given added total.
        public int FindMissingNumber(int[] nums)
        {
            int n = nums.Length;
            int totalSum = n * (n + 1) / 2;
            int inputSum = 0;
            foreach (int num in nums)
            {
                inputSum += num;
            }
            return totalSum - inputSum;
        }
    }

    class Application
    {
        static void Main(string[] args)
        {
            var console = new ConsoleActions();
            var finder = new MissingNumberFinder();
            int missingNumber = finder.FindMissingNumber(console.GetUserInput());
            Console.WriteLine($"Missing Number is: {missingNumber}");
        }
    }
}
