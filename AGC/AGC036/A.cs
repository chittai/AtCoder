using System;

namespace AGC036
{
    class A
    {
        static void Main(string[] args)
        {
            long W = 1000000000;
            long S = long.Parse(Console.ReadLine());
            long x = (W - S % W) % W;
            long y = (S + x) / W;
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", 0, 0, W, 1, x, y);
        }
    }
}
