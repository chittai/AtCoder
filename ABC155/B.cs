using System;
using System.Linq;

namespace ABC155
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0 && (A[i] % 3 != 0 && A[i] % 5 != 0)) { Console.WriteLine("DENIED"); return; }
            }
            Console.WriteLine("APPROVED");
        }

    }
}
