using Missing_Number_Finder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Number_Finder.App
{
    public class MissingNumberFinderApp
    {
        private IConsoleActions _console;
        private IMissingNumberFinder _missingNumberFinder;

        public MissingNumberFinderApp(IConsoleActions console, IMissingNumberFinder missingNumberFinder)
        {
            _console = console;
            _missingNumberFinder = missingNumberFinder;
        }

        public void Run()
        {
            int[] nums = _console.GetUserInput();
            int missing = _missingNumberFinder.FindMissingNumber(nums);
            Console.WriteLine($"Missing Number is: {missing}");
        }
    }
}
