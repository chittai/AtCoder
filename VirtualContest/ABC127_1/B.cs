using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC127_1
{
    class B
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = a[0];
            var D = a[1];
            var x = a[2];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r * x - D);
                x = r * x - D;
            }
        }
    }
}
