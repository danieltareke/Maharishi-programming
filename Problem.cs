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
        /*
         * The number 198 has the property that 198 = 11 + 99 + 88, i.e., if each of its digits is concatenated twice
            and then summed, the result will be the original number. It turns out that 198 is the only number with this
            property. However, the property can be generalized so that each digit is concatenated n times and then
            summed. For example, 2997 = 222+999+999+777 and here each digit is concatenated three times. Write a
            function named checkContenatedSum that tests if a number has this generalized property.
            The signature of the function is
            int checkConcatenatedSum(int n, int catlen) where n is the number and catlen is the number of times to
            concatenate each digit before summing.
            The function returns 1 if n is equal to the sum of each of its digits contenated catlen times. Otherwise, it
            returns 0. You may assume that n and catlen are greater than zero
            Hint: Use integer and modulo 10 arithmetic to sequence through the digits of the argument
         */

        public int checkConcatenatedSum(int n, int catlen)
        {
            int isConcatenatedSum = 0;
            int sum = 0;
            int num = n;
            
            while (num >= 1)
            {
                int tempsum = 0;
                int lastDigit = num % 10;
                num = num / 10;
                int tens = 1;
                for (int i = 1; i <= catlen; i++)
                {
                    tempsum += (tens * lastDigit);
                    tens *= 10;
                }
                sum = sum + tempsum;
            }

            if (sum == n)
                isConcatenatedSum = 1;

            return isConcatenatedSum;
        }
    }
}
