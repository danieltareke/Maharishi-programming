using System;
using System.Collections;

namespace Maharishi
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem();
            //largestAdjacentSum
            int[] data = { 1, 1, 1, 1, 1, 2, 1, 1, 1 };
            string response = problem.largestAdjacentSum(data).ToString();
            // Console.WriteLine(response);

            //checkConcatenatedSum
            response = problem.checkConcatenatedSum(2997, 3).ToString();
            //Console.WriteLine(response);

            //isSequencedArray
            int[] d = { -5, -5, -4, -4, -4, -3, -3, -2, -2, -2 };
            response = problem.isSequencedArray(d, -5, -2).ToString();
            // Console.WriteLine(response);

            //largestPrimeFactor
            response = problem.largestPrimeFactor(6936).ToString();
            //Console.WriteLine(response);

            //encodeNumber
            int [] res = problem.encodeNumber(1200);
            //if (res != null)
            //{
            //    for (int i = 0; i < res.Length; i++)
            //    {
            //        Console.WriteLine(res[i] + ",");
            //    }
            //}

            //int[] array = { 1, 2, 3 };
            // int[] pattern = { 1, 2,3};
            //int match = problem.matchPattern(array ,3,pattern,3);
            // Console.WriteLine(match);

            //int[] a = { 1, 2, 3, 4, 5 };
            //int[] result = problem.doIntegerBasedRounding(a,2);
            //for (int i=0;i<result.Length;i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //Console.WriteLine(problem.isCubePowerful(87));

            //int[] a = { 111, 115, 118, 127, 125 };
            //int k=decodeArray(a);
            //Console.WriteLine(k);

            //int[] a = {  0 };
            //int p=isZeroPlentiful(a);
            //Console.WriteLine(p);

            //Console.WriteLine(isDigitIncreasing(7404));

            //int[] a = { -1,0,1 };
            //int p = decodeArray(a);
            //Console.WriteLine(p);

            //int[] a = { };
            //int p = isOnionArray(a);
            //Console.WriteLine(p);

            //Console.WriteLine(isPrimeHappy(8));

            //encodeArray(-1);
            //int[] a = { 1, 1, 3 };
            //int k = isSystematicallyIncreasing(a);

            ///Console.Write(k);
            ///

            NewProblems newp = new NewProblems();
            int[] a = {  1, 2, 4, -1 } ;
            //int result=newp.isInfinite(a);
            //Console.WriteLine(result);

            //int[] aa = { -3, -3, 6, 12, 24 };
            // int result = newp.isCumulative(aa);
            //Console.WriteLine(result);

            //int[] b = { -1, 2, -1 };
            //int r = newp.loopSum(b,7);
            //int r = newp.hasNFollowingComposites(24,4);
            //int[] a1 = { };
            //int[] a2 = { 3, 1, 1, 1, 1, 2 };
            //int r = newp.equivalentArrays(a1,a2);
            //int[] a2 = { 1, 2, 2, 1 };
            //int r = newp.hasTwoValues(a2);
            //int[] a2 = {};
            //int r = newp.isSorted(a2);
            //Console.WriteLine(r);
            //int r = newp.isNormal(12);
            //Console.WriteLine(r);
            //int[] a2 = { 0, 0, 1, 0, 0 };
            int r = newp.isBunker(8);
            Console.WriteLine(r);
            Console.ReadKey();
        }

        static int isSystematicallyIncreasing(int[] a)
        {
            if (a == null || a.Length == 0) return 0;
            // if first element is not 1 or length is 2 (Eg. {1, 1})
            if (a[0] != 1 || a.Length == 2) return 0;

            int startIndex = 1;
            int j;
            // start an outer loop so that inner loop can test for values
            for (int i = 2; i < a.Length; i++)
            {
                // to remove array with incomplete digits (Coz length needs to be 1, 3, 6, 10, 15 and so on)
                if (a.Length < i + startIndex)
                {
                    return 0;
                }
                // test for values using inner loop
                int num = 1;
                for (j = startIndex; j < i + startIndex; j++)
                {
                    if (a[j] != num)
                    {
                        return 0;
                    }
                    num++;
                }
                // if all digits in the array are tested and none are failing above conditions,
                // the array must now be a SystematicallyIncreasing array
                if (a.Length == i + startIndex)
                {
                    break;
                }
                startIndex = j;
            }
            return 1;
        }

        static void encodeArray(int n)
        {
            int digit = 0;
            int m = n;
            ArrayList list = new ArrayList();
            ArrayList encoded = new ArrayList();
            

            if (n < 0)
                encoded.Add(-1);

            while (m != 0)
            {                
                int r = m % 10;
                m = m / 10;
                list.Add(r);
            }

            
            for (int i=list.Count-1;i>=0;i--)
            { 
                for (int j=0;j<Math.Abs((int)list[i]);j++)
                {
                    encoded.Add(0);
                }
                encoded.Add(1);
            }


            foreach (var k in encoded)
            {
                Console.Write(k);

            }

            
        }

        static int isPrimeHappy(int n)
        {
            if (n == 2)
                return 0;

            int sum = 2;
            for(int i=3;i<n;i++)
            {
                bool isPrime = true;
                for (int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    sum += i;
            }

            if (sum % n == 0)
                return 1;
            else
                return 0;

            
        }
        static int isOnionArray(int[] a)
        {
            int result = 1;//is onion

            for(int i=0,k=a.Length-1;i<k;i++,k--)
            {
                if(a[i]+a[k]>10)
                    return 0;
            }
            return result;
        }

        static int decodeArray(int[] a)
        {
            bool negative = false;
            if (a[0] == -1)
            {
                a[0] = 1;
                negative = true;
            }

            int digitcount = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] == 1)
                    digitcount += 1;
            }

            int tempZeros = 0;
            int digit = 0;
            int sum = 0;

            
             for (int i = 0; i < a.Length; i++)
            {
                 //if (a[i] == -1)
                 //   continue;

                 if (a[i] == 0)
                    tempZeros += 1;                

                else
                {
                    digit += 1;
                    sum = sum + tempZeros * (int)Math.Pow(10, digitcount - digit);
                    tempZeros = 0;
                }                
                  
            }

            if (negative)
                sum = sum * -1;

            return sum;
        }

        static int isDigitIncreasing(int n)
        {
            int digits = 0;
            int m = n;

            while(m>0)
            {
                digits += 1;
                m=m / 10;
            }

            for (int i=1;i<=9;i++)
            { 
                int sum = 0;
                for(int k=0;k<digits;k++)
                {
                    //sum +=  i*(int)Math.Pow(10,k);
                    for (int j=0;j<=k;j++)
                    {
                        sum += i * (int)Math.Pow(10, j);
                    }
                }

                if (sum == n)
                {
                    Console.WriteLine("the number is "+i);
                    return 1;
                };
            }

            return 0;
        }

        static int isZeroPlentiful(int[] a)
        {
            //bool isZeroPlentiful = false;
            //bool counting = false;
            int fourzeros = 0;
            int tempZeros = 0;


            for (int i=0;i < a.Length;i++)
                {
                    if(a[i]==0)
                    {    
                        tempZeros += 1;
                    }
                    else
                    {
                        if (tempZeros > 0)
                        {
                            if (tempZeros >= 4)
                                fourzeros += 1;
                            else
                                return 0;
                        }
                        tempZeros = 0;                       

                    }
            }

            if (tempZeros > 0)
            {
                if (tempZeros >= 4)
                    fourzeros += 1;
                else
                    return 0;
            }

            return fourzeros;

            
        }

        static int decodeArray1(int[] a)
        {
            int num = 0;

            for(int i=0;i<a.Length-1; i++)
            {
                num += Math.Abs(a[i] - a[i + 1])*(int)Math.Pow(10,a.Length-(i+2)) ;
            }

            if (a[0] < 0)
                num=num * -1;

            return num;
        }


    }
}
