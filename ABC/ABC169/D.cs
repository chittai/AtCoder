using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC169
{
    class D
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var Res = new long[100000000];
            var dict = new Dictionary<long, long>();
            long j;

            if (IsPrime(N)) { Console.WriteLine(1); return; }
            //Console.WriteLine("--- 1 --");
            j = 2;
            var Ntemp = N;
            while (j * j <= N)
            {
                while (Ntemp % j == 0)
                {
                    if (!dict.ContainsKey(j)) dict.Add(j, 1);
                    else dict[j]++;
                    //Res[j]++;
                    Ntemp /= j;
                }
                j++;
            }
            // Console.WriteLine("--- 2 --");


            var res = 0;
            if (Ntemp != 1) res = 1;

            foreach (var i in dict.Values)
            {
                var temp = i;
                var index = 1;
                while (index <= temp)
                {
                    temp -= index;
                    index++;
                    res++;
                }
            }
            Console.WriteLine(res);
        }

        public static bool IsPrime(long num)
        {
            if (num < 2) return false;
            else if (num == 2) return true;
            else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

            double sqrtNum = Math.Sqrt(num);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (num % i == 0)
                {
                    // 素数ではない
                    return false;
                }
            }

            // 素数である
            return true;
        }
    }
}
