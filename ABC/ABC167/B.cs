using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC167
{
    class B
    {
        static void Main(string[] args)
        {
            var ABCK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = ABCK[0]; var B = ABCK[1]; var C = ABCK[2]; var K = ABCK[3];

            var res = 0L;

            if (K <= A) res = K;
            else if (K <= A + B) res = A;
            else res = A + (K - (A + B)) * -1;

            Console.WriteLine(res);

        }
    }
}

