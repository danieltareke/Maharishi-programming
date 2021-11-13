using System;
using System.Collections.Generic;
using System.Text;

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
            int largestsum = a[0] + a[1];

            for (int i = 0; i < a.Length - 1; i++)
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
         * Define an m-n sequenced array to be an array that contains one or more occurrences of all the integers
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
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i]) < m || (a[i]) > n)
                {
                    isSequenced = 0;
                    break;
                }
            }
            int t = m;
            //check if all exisit in the array
            while (t <= n)
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

                if (!isFound)
                {
                    isSequenced = 0;
                    break;
                }
                t++;
            }
            //check if the array is sequenced

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    isSequenced = 0;
                    break;
                }
            }

            return isSequenced;
        }

        /*
         Write a function named largestPrimeFactor that will return the largest prime factor of a number. If the
        number is <=1 it should return 0. Recall that a prime number is a number > 1 that is divisible only by 1 and
        itself, e.g., 13 is prime but 14 is not.
        */
        public int largestPrimeFactor(int n)
        {
            int largestPrimeN = 0;
            if (n <= 1)
                return 0;

            int number = n;

            for (int i = 2; i < number; i++)
            {
                while (number % i == 0)
                {
                    if (i > largestPrimeN)
                        largestPrimeN = i;

                    number = number / i;
                }
            }
            if (number > 2)
            {
                if (number > largestPrimeN)
                    largestPrimeN = number;
            }

            return largestPrimeN;
        }

        /*
         * The fundamental theorem of arithmetic states that every natural number greater than 1 can be written as a
            unique product of prime numbers. So, for instance, 6936=2*2*2*3*17*17. Write a method named
            encodeNumber what will encode a number n as an array that contains the prime numbers that, when
            multipled together, will equal n. So encodeNumber(6936) would return the array {2, 2, 2, 3, 17, 17}. If the
            number is <= 1 the function should return null;
         */

        public int[] encodeNumber(int n)
        {
            List<int> arrayList = new List<int>();

            if (n <= 1)
                return null;
            else
            {
                int number = n;

                for (int i = 2; i < number; i++)
                {
                    while (number % i == 0)
                    {
                        arrayList.Add(i);
                        number = number / i;
                    }
                }
                if (number >= 2)
                {
                    arrayList.Add(number);
                }


                return arrayList.ToArray();
            }
        }

        /*
         * Consider a simple pattern matching language that matches arrays of integers. A pattern is an array of
            integers. An array matches a pattern if it contains sequences of the pattern elements in the same order as
            they appear in the pattern. So for example, the array {1, 1, 1, 2, 2, 1, 1, 3} matches the pattern {1, 2, 1, 3}
         */

        public int matchPattern(int[] a, int len, int[] pattern, int patternLen)
        {
            // len is the number of elements in the array a, patternLen is the number of elements in the pattern.
            int i = 0; // index into a
            int k = 0; // index into pattern
            int matches = 0; // how many times current pattern character has been matched so far
                for (i = 0; i < len; i++)
                {
                    if (a[i] == pattern[k])
                        matches++; // current pattern character was matched
                    else if (matches == 0 || k == patternLen - 1)
                        return 0; // if pattern[k] was never matched (matches==0) or at end of pattern (k==patternLen-1)
                    else // advance to next pattern character 
                    {
                         k++; 
                        //!!You write this code!!
                    } // end of else
            } // end of for
            // return 1 if at end of array a (i==len) and also at end of pattern (k==patternLen-1)
            if (i==len && k==patternLen-1) return 1;
            else return 0;
        }

        /*
         * Define the n-based integer rounding of an integer k to be the nearest multiple of n to k. If two multiples
            of n are equidistant use the greater one. For example
         */
        public int[] doIntegerBasedRounding(int[] a, int n)
        {
            if (n > 0)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0)
                    {
                        int rem = a[i] % n;
                        a[i] = a[i] - rem + (rem >= n / 2 ? n : 0);
                    }
                }
            }
            return a;
        }

        public int isCubePowerful(int n)
        {
            int resu = 0;
            int sum = 0;
            int m = n;

            while(m>0)
            {
                int r = m % 10;
                m = m / 10;
                sum = sum + (int)Math.Pow(r,3);
            }

            if (n == sum) 
                resu = 1;
            else
                resu = 0;

            return resu;
        }
    }
}
