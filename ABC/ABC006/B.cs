using System;

namespace ABC006
{
    class B
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ulong[] a = new ulong[n + 1];
            if (3 <= n) { a[2] = 1; }

            for (int i = 3; i < n; i++)
            {
                a[i] = (a[i - 3] + a[i - 2] + a[i - 1]) % 10007;
            }
            Console.WriteLine(a[n - 1]);
        }
    }
}
