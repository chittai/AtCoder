using System;
using System.Linq;

namespace ARC068
{
    class C
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());

            long a = x / 11;
            long b = x % 11;

            if (a == 0 && b <= 6) { Console.WriteLine(1); return; }
            else if (a == 0 && 6 < b) { Console.WriteLine(2); return; }

            if (0 < a && 0 <= b)
            {
                if (0 < b && b <= 6) { Console.WriteLine(2 * a + 1); return; }
                else if (6 < b) { Console.WriteLine(2 * a + 2); return; }
                else if (b == 0) { Console.WriteLine(2 * a); return; }
            }
        }
    }
}
