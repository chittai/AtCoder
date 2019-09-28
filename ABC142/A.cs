using System;

namespace ABC142
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 1) Console.WriteLine((double)(N / 2 + 1) / (double)N);
            else Console.WriteLine((double)(N / 2) / (double)N);
        }
    }
}
