using System;
using System.Linq;

namespace ABC112
{
    class B2
    {
        static void Main(string[] args)
        {
            Func<int[]> read = () => Console.ReadLine().Split().Select(int.Parse).ToArray();
            var h = read();
            Console.WriteLine(Enumerable.Repeat(0, h[0]).Select(_ => read()).OrderBy(r => r[0]).FirstOrDefault(r => r[1] <= h[1])?[0].ToString() ?? "TLE");
        }
    }
}
