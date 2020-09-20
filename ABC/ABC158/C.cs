using System;
using System.Linq;

namespace ABC158
{
    class C
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = a[0];
            var B = a[1];

            for (int i = 1; i <= 1000; i++)
            {
                if ((int)(i * 0.08) == A && (int)(i * 0.10) == B) { Console.WriteLine(i); return; }
            }
            Console.WriteLine(-1);

        }
    }
}
