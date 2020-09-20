using System;
using System.Linq;

namespace ABC145
{
    class A
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            double s1 = 1 * 1 * Math.PI;
            double s2 = r * r * Math.PI;
            Console.WriteLine(s2 / s1);
        }
    }
}
