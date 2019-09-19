using System;
using System.Linq;

namespace ABC082
{
    class A
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine(Math.Ceiling((s[0] + s[1]) * 0.5));
        }
    }
}
