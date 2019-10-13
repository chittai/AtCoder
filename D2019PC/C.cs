using System;
using System.Collections.Generic;

namespace D2019PC
{
    class C
    {
        static void Main(string[] args)
        {

            long N = long.Parse(Console.ReadLine());

            List<long> list = new List<long>();
            for (long i = 1; i < Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    list.Add((N / i) - 1);
                }
            }

            long count = 0;
            foreach (var i in list)
            {
                if (N % i != 0) count += i;
            }
            Console.WriteLine(count);
        }
    }
}
