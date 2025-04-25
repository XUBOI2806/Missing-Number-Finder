using Missing_Number_Finder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Number_Finder.Services
{
    public class MissingNumberFinder : IMissingNumberFinder
    {
        // Finds the missing number by finding the length of the list, then finding the added total and deducting that with given added total.
        public int FindMissingNumber(int[] numList)
        {
            int n = numList.Length;
            int totalSum = n * (n + 1) / 2;
            int inputSum = 0;
            foreach (int num in numList)
            {
                inputSum += num;
            }
            return totalSum - inputSum;
        }
    }
}
