using System;
using System.Linq;

namespace ABC120
{
    class C
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            Console.WriteLine(2 * Math.Min(S.Count(x => x == '0'), S.Count(x => x == '1')));
        }
    }
}
