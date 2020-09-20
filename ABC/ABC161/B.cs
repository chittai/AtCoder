using System;
using System.Linq;

namespace ABC161
{
    class B
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var n = a[0]; var m = a[1];
            var A = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double sum = A.Sum();
            double count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sum * (1 / (4 * m)) <= A[i]) count++;
            }

            if (m <= count) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
