using System;
using System.Linq;

namespace AGC013
{
    class A
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int flag = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (flag == 1 && A[i] > A[i + 1]) { count++; flag = 0; continue; }
                if (flag == -1 && A[i] < A[i + 1]) { count++; flag = 0; continue; }

                if (A[i] < A[i + 1]) { flag = 1; }
                if (A[i] > A[i + 1]) { flag = -1; }

            }
            Console.WriteLine(count);
        }
    }
}
