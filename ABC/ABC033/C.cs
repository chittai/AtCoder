using System;
using System.Linq;

namespace ABC033
{
    class C
    {
        static void Main(string[] args)
        {
            string[] S = Console.ReadLine().Split('+');
            int count = 0;
            foreach (var s in S)
            {
                if (!s.Contains('0')) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
