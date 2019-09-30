using System;
using System.Linq;

namespace ABC139
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long res = 0;
            for (long i = 0; i < N; i++)
            {
                res += i;
            }
            Console.WriteLine(res);
        }
    }
}
