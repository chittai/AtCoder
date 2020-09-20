using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC167
{
    class A
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();

            var t = T.Substring(0, S.Length);

            if (S == t && S.Length == T.Length - 1) Console.WriteLine("Yes");
            else Console.WriteLine("No");


        }
    }
}
