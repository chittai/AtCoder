using System;
using System.Linq;

namespace ZTP001
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] != B[i] && B[i] != C[i] && A[i] != C[i]) count += 2;
                else if (A[i] == B[i] && B[i] == C[i] && A[i] == C[i]) { }
                else count++;
            }

            Console.WriteLine(count);
        }
    }
}
