using System;
using System.Linq;

namespace ABC158
{
    class B
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = a[0];
            var A = a[1];
            var B = a[2];

            if (N % (A + B) == 0) Console.WriteLine((N / (A + B)) * A);
            else if (N % (A + B) <= A) Console.WriteLine((N / (A + B)) * A + (N % (A + B)));
            else Console.WriteLine((N / (A + B)) * A + A);

        }
    }
}
