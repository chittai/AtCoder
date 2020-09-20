using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC127_1
{
    class C
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int L = 0;
            int R = int.MaxValue;
            for (int i = 0; i < a[1]; i++)
            {
                var b = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (L < b[0]) L = b[0];
                if (b[1] < R) R = b[1];
            }
            if (R - L + 1 < 0) Console.WriteLine(0);
            else Console.WriteLine(R - L + 1);
        }
    }
}
