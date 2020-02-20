using System;
using System.Linq;

namespace ABC098
{
    class D
    {
        static void Main(string[] args)
        {

            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long res = 0;
            long right = 0;
            long sum = 0;
            for (long left = 0; left < N; left++)
            {
                while (right < N && (sum ^ A[right]) == (sum + A[right]))
                {
                    sum += A[right];
                    right++;
                }

                res += right - left;

                if (right == left) right++;
                else { sum -= A[left]; }
            }
            Console.WriteLine(res);
        }
    }
}
