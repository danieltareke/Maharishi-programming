using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maharishi
{
    
    public class NewProblems
    {
        public int isBunker(int n)
        {
            int a = 0, b = 1, c = 0, j = 0;
            while (c < n)
            {
                c = a + b;
                a = j;
                b = c;
                j++;

            }
            if (c == n)
                return 1;
            else
                return 0;
        }


        public int isNZeroPacked(int[] a, int n)
        {
            if (a.Length < n + 2)
                return 0;
            bool visitedNonZero = false;
            int countZeros = 0;
            bool countingZero = false;
            for(int i=0;i<a.Length;i++ )
            {
                if (a[i] == 0)
                { 
                    if(countingZero)
                        countZeros = countZeros + 1; 
                    else
                    {
                        countingZero = true;
                        countZeros = 1;
                    }
                }
                else
                {
                    
                    if (countZeros != n&& visitedNonZero)
                        return 0;
                    if (countZeros == n && !visitedNonZero)
                        return 0;

                    visitedNonZero = true;
                    countingZero = false;
                }
                
            }
            if (!visitedNonZero)
                return 0;

            return 1;

        }       
        public int ancientMultiplication(int n1, int n2)
        {
            return 0;
        }
        public int countDimples(int []a)
        {
            int count = 0;
            for (int i = 1; i < a.Length-1; i++)
            {
                if (a[i]<a[i-1] && a[i] < a[i + 1])
                    count++;
            }

            return count;

        }
         public bool isPalindrome(char[] arr)
        {
            if (arr.Length < 1)
                return false;
            for (int i = 0,j=arr.Length-1; i <j; i++,j--)
            {
                if (arr[i] != arr[j])
                    return false;
            }

            return true;
         }
        public double eval(double x, int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i] * Math.Pow(x, i);
            }

            return sum;
         }
        public int isBalanced(int[] a)
        {
            for (int i = 0; i <a.Length; i++)
            {
                if(i%2==0)
                {
                    if (a[i] % 2 != 0)
                        return 0;
                }
                else
                {
                    if (a[i] % 2 == 0)
                        return 0;
                }
            }

            return 1;
        }
        //difficult
        public char[] getChar(char[] a, int start, int len)
        {
            int n = len+start-1;
            if (start < 0 ||len<0)
                return null;
            if (a.Length < len)
                return null;
            if (n >= a.Length)
                return null;
            char[] aa = new char[len];
            int j = 0;
            for(int i=start; i<=n;i++)
            {
                aa[j] = a[i];
                j++;
            }
            return aa;
        }
        public int sumOddEven(int[] a)
        {
            int odd = 0;
            int even = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    even = even + a[i];
                else
                    odd=odd + a[i];
            }

            return odd - even;

        }
            public int secondLargest(int[] a)
        {
            if (a.Length < 2)
                return -1;
            int largest = int.MinValue;
            int second = int.MaxValue; 
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]>largest)
                {
                    second = largest;
                    largest = a[i];                    
                }
                else if ((a[i] > second) && (a[i] != largest))
                    second = a[i];

            }
            if (second == int.MinValue) 
                return -1;
            return second;
         }
        public int isLayered(int[] a)
        {
            if (a.Length < 2)
                return 0;
            int current = a[0];
            int count = 1;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != current)
                {
                    if (count < 2)
                        return 0;

                    if (a[i] > a[i - 1])
                    {
                        count = 0;
                        current = a[i];
                    }
                    else
                        return 1;
                }
                else
                {
                    count = count + 1;
                }

            }
            return 1;
        }

        public int isAllPossibilities(int[] a)
        {
            if (a.Length == 0)
                return 0;
            for(int i = 0; i < a.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if(i==a[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    return 0;
            }
            return 1;
        }
        public int isDual(int[] a)
        {
            if (a.Length % 2 != 0)
                return 0;

            for(int i = 0; i < a.Length-3; i++)
            {
                int k = a[i] + a[i+1];
                int p = a[i+2] + a[i + 3];

                if (k != p)
                    return 0;
            }
            return 1;
        }
        public int isNormal(int n)
        {
            if (n < 3)
                return 1;
            for(int i = 3; i < n; i++)
            {
                if (n % i == 0 && i % 2 != 0)
                    return 0;
            }

            return 1;
        }


        public int isSorted(int[] a)
        {
            bool asc = true;
            bool desc = true;
            for (int i=0;i<a.Length-1;i++)
            {
                if (a[i] < a[i + 1])
                    desc = false;
                if (a[i] > a[i + 1])
                    asc = false;
            }

            if (asc || desc)
                return 1;
            else
                return 0;
        }
        public int hasTwoValues(int[] a)
        {
            int elementOne=0,elementTwo=0;
            bool elementTwoChecked = false;
            if (a.Length < 2)
                return 0;
            elementOne = a[0];
            for (int i=1;i<a.Length;i++)
            {
                if(elementTwoChecked)
                {
                    if ((a[i] != elementOne) && (a[i] != elementTwo))
                        return 0;
                }
                else
                {
                    if (a[i] != elementOne)
                    {
                        elementTwoChecked = true;
                        elementTwo = a[i];
                    }    
                }
                
            }
            if (elementTwoChecked)
                return 1;
            else
                return 0;
        }
        public int equivalentArrays(int[] a1, int[] a2)
        {
            if (a1.Length != a2.Length)
                return 0;
            for (int i = 0; i < a1.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j])
                        count = +1;
                }
                if (count != 1)
                    return 0;
            }
            return 1;
        }

        public int hasNFollowingComposites(int n, int count)
        {
            if (n <= 1)
                return 0;

            if (!isPrime(n))
                return 0;

            int m = n+count;
            for (int i = n+1; i < m; i++)
            {
                if (isPrime(m))
                    return 0;
            }

            return 1;

        }

        private bool isPrime(int m)
        {            
            for (int i = 2; i < m; i++)
            {
                if (m % i == 0)
                    return false;
            }
            return true;
        }
        public int loopSum(int[] a, int n)
        {
            int sum = a[0];
            int i = 1;
            n--;
            while (n > 0)
            {                
                sum = sum + a[i];
                n--;
                if (i < a.Length)
                    i++;
                if (i == a.Length)
                    i = 0;
            }

            return sum;
        }
        public int isInfinite(int[] a)
        {
            for (int i=0;i<a.Length;i++)
            {
                if (a[i] == -1)
                    return -1;
                else if (a[i] < -1 || a[i] >= a.Length)
                    return 1;
                //else
                //{
                //    if (a[a[i]] == -1)
                //        return -1;
                //    else if (a[a[i]] < -1 || a[a[i]] > a.Length)
                //        return 1;
                //    else
                //        return 0;
                //}
            }
            return 0;
        }

        public int isCumulative(int[] a)
        {
            if (a.Length < 2)
                return 0;

            int sum = a[0];

            for(int i=1;i<a.Length;i++)
            {
                if (a[i] != sum)
                    return 0;
                else
                    sum = sum + a[i];
            }
            return 1;
        }

    }
}
