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

using Missing_Number_Finder.App;
using Missing_Number_Finder.Interfaces;
using Missing_Number_Finder.Services;

class Program
{
    static void Main(string[] args)
    {
        IConsoleActions console = new ConsoleActions();
        IMissingNumberFinder missingNumberFinder = new MissingNumberFinder();
        var app = new MissingNumberFinderApp(console, missingNumberFinder);
        app.Run();
    }
}
