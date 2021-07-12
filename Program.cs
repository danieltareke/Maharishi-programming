using System;

namespace Maharishi
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem();
            //largestAdjacentSum
            int[] data= { 1, 1, 1, 1, 1, 2, 1, 1, 1 };
            string response = problem.largestAdjacentSum(data).ToString();
            Console.WriteLine(response);

            //checkConcatenatedSum
            response = problem.checkConcatenatedSum(2997,3).ToString();
            Console.WriteLine(response);
        }
    }


   
}
