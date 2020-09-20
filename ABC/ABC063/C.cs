using System;
using System.Linq;

namespace ABC063
{
    class C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var s = Enumerable.Repeat(0, N).Select(_ => int.Parse(Console.ReadLine())).OrderBy(x => x).ToArray();
            var sum = s.Sum();
            if (sum % 10 != 0) { Console.WriteLine(sum); return; }
            for (int i = 0; i < N; i++)
            {
                sum -= s[i];
                if (sum % 10 != 0) break;
                sum += s[i];
            }

            if (sum % 10 == 0) Console.WriteLine(0);
            else Console.WriteLine(sum);

        }
    }
}
