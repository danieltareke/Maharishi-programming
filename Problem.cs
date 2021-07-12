using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maharishi
{
    public class Problem
    {
        /*
         Write a function named largestAdjacentSum that iterates through an array computing the sum of
        adjacent elements and returning the largest such sum. You may assume that the array has at least 2
        elements.
        */
        public int largestAdjacentSum(int[] a)
        {
            int largestsum= a[0] + a[1];

            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] + a[i + 1] > largestsum)
                    largestsum = a[i] + a[i + 1];
            }

            return largestsum;
        }
    }
}
