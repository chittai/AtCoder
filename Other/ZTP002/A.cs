using System;

namespace ZTP002
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 2 == 0) Console.WriteLine(N / 2 - 1);
            else Console.WriteLine(N / 2);
        }
    }
}
