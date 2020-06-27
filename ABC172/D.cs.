using System;
using System.Linq;

namespace ABC172
{
    class D
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var Count = new long[N + 10].Select(x => x = 1).ToArray();

            for (int i = 2; i <= N; i++)
            {
                var index = 1;
                while (i * index <= N)
                {
                    Count[i * index]++;
                    index++;
                }
            }

            var sum = 0L;
            for (int i = 1; i <= N; i++)
            {
                sum += Count[i] * i;
            }

            //Console.WriteLine(string.Join(" ", Count));
            Console.WriteLine(sum);
        }
    }
}
