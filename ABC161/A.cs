using System;
using System.Linq;

namespace ABC161
{
    class A
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("{0} {1} {2}", a[2], a[0], a[1]);
        }
    }
}
