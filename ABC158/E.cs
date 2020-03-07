using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC158
{
    class E
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var s = Console.ReadLine();
            var N = a[0];
            var P = a[1];

            int right = 0;
            int res = 0;

            for (int left = 0; left < N; left++)
            {
                if (right == left) right++;
                var sub = long.Parse(s.Substring(left, right - left));

                while (right < N && sub % P == 0)
                {
                    right++;
                    sub = long.Parse(s.Substring(left, right - left));
                    //Console.WriteLine(sub);
                }
                res += right - left;


            }

            Console.WriteLine(res);
        }
    }
}
