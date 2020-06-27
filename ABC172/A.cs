using System;
using System.Linq;

namespace ABC172
{
    class A
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            Console.WriteLine(a + Math.Pow(a, 2) + Math.Pow(a, 3));
        }
    }
}
