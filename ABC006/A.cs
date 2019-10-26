using System;

namespace ABC006
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 3 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
