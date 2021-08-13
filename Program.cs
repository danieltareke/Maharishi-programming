using System;

namespace Maharishi2
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

            int[] a = { 1, 2, 3, 4, 5 };
            int[] result = problem.doIntegerBasedRounding(a,2);
            for (int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
          
            Console.ReadKey();
        }
    }
}
