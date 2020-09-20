using System;
using System.Linq;

namespace ABC144
{
    class D
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double a = input[0];
            double b = input[1];
            double x = input[2];

            var S = x / a;

            if (a * b / 2 < S)
            {
                var h = (a * b - S) * 2 / a;
                var deg = Math.Atan2(a, h) * 180 / Math.PI;
                Console.WriteLine(90 - deg);
            }
            else
            {
                var w = 2 * S / b;
                var deg = Math.Atan2(w, b) * 180 / Math.PI;
                Console.WriteLine(90 - deg);
            }
        }
    }
}
