using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC126_1
{
    class B
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var s1 = int.Parse(s.Substring(0, 2));
            var s2 = int.Parse(s.Substring(2, 2));

            if ((1 <= s1 && s1 <= 12) && (1 <= s2 && s2 <= 12)) Console.WriteLine("AMBIGUOUS");
            else if ((1 <= s1 && s1 <= 12) && (s2 == 0 || 12 < s2)) Console.WriteLine("MMYY");
            else if ((s1 == 0 || 12 < s1) && (1 <= s2 && s2 <= 12)) Console.WriteLine("YYMM");
            else Console.WriteLine("NA");
        }
    }
}
