using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC130_1
{
    class B
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var l = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = 0;
            var res = 1;
            for (int i = 1; i < a[0] + 1; i++)
            {
                sum += l[i - 1];
                if (a[1] < sum) break;
                res++;
            }
            Console.WriteLine(res);
        }
    }
}
