using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
		//https://codility.com/c/run/demoCV36DV-KCK
        static void Main(string[] args)
        {
            /*
            Write a function:
            class Solution { public int solution(int[] A); }
            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
            For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            For another example, given A = [1, 2, 3], the function should return 4.
            Given A = [−1, −3], the function should return 1.
            Assume that:
            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
            Complexity:

            expected worst-case time complexity is O(N);
            expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).
            Elements of input arrays can be modified.
            */
            int[] A;

            A = new int[] { 1, 3, 6, 4, 1, 2 };
            PrintSolution(A);

            A = new int[] { 1, 3, 6, 4, 1, 2 };
            PrintSolution(A);

            A = new int[] { 1, 2, 3 };
            PrintSolution(A);

            A = new int[] { -1, -3 };
            PrintSolution(A);

            A = new int[] { -872181, -347245, -439725, 13510, -761374, 983456, -165776, 583618, -934660, 109801, -276272, 74477 };
            PrintSolution(A);

            A = new int[] { 2 };
            PrintSolution(A);
        }

        public static void PrintSolution(int[] A)
        {
            int mySolution = 0;
            Stopwatch s = new Stopwatch();
            s.Start();
            mySolution = solution(A);
            s.Stop();
            TimeSpan ts = s.Elapsed;
            Console.WriteLine($"{mySolution}: {ts.TotalMilliseconds}ms");
        }

        public static int solution(int[] A)
        {
            if (!A.Contains(1))
            {
                return 1;
            }

            int retVal = 1;
            A = A.Where(a => a > 0).ToArray();
            A = A.Distinct().ToArray();
            Array.Sort(A);

            int next = 0;
            foreach (int i in A)
            {
                next = i + 1;
                if (!A.Contains(next))
                {
                    retVal = next;
                    break;
                }
            }
            return retVal;
        }
    }
}
