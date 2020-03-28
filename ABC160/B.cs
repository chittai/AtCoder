using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC160
{
    class B
    {
        static void Main(string[] args)
        {
            var X = long.Parse(Console.ReadLine());
            Console.WriteLine((X / 500 * 1000) + ((X % 500) / 5) * 5);
        }
    }
}
