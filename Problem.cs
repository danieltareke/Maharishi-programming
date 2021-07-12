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

        /*
         * efine an m-n sequenced array to be an array that contains one or more occurrences of all the integers
            between m and n inclusive. Furthermore, the array must be in ascending order and contain only those
            integers. For example, {2, 2, 3, 4, 4, 4, 5} is a 2-5 sequenced array. The array {2, 2, 3, 5, 5, 5} is not a 2-5
            sequenced array because it is missing a 4. The array {0, 2, 2, 3, 3} is not a 2-3 sequenced array because the
            0 is out of range. And {1,1, 3, 2, 2, 4} is not a 1-4 sequenced array because it is not in ascending order.
            Write a method named isSequencedArray that returns 1 if its argument is a m-n sequenced array,
            otherwise it returns 0.
        */
        public int isSequencedArray(int[] a, int m, int n)
        {
            int isSequenced = 1;
            //check if there is out of range value
            for(int i=0;i<a.Length;i++)
            {
                if((a[i])<m || (a[i]) > n)
                {
                    isSequenced = 0;
                    break;
                }
            }
            int t = m;
            //check if all exisit in the array
            while(t<=n)
            {
                bool isFound = false;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == t)
                    { 
                        isFound = true;
                        break;
                    }
                }

                if(!isFound)
                {
                    isSequenced = 0;
                    break;
                }
                t++;
            }
            //check if the array is sequenced

            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i]>a[i+1])
                {
                    isSequenced = 0;
                    break;
                }
            }

            return isSequenced;
        }
    }
}
