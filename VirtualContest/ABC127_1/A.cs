using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC127_1
{
    class A
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = a[0];
            var B = a[1];

            if (13 <= A) Console.WriteLine(B);
            else if (6 <= A && A <= 12) Console.WriteLine(B / 2);
            else Console.WriteLine(0);
        }
    }
}
