using System;
using System.Linq;

namespace ABC153
{
    class D
    {
        static void Main(string[] args)
        {
            long H = long.Parse(Console.ReadLine());
            long res = 0;
            long index = 0;
            while (0 < H)
            {
                res += (long)Math.Pow(2, index);
                H /= 2;
                index++;
            }
            Console.WriteLine(res);
        }
    }
}
