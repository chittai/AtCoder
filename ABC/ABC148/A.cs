using System;
using System.Linq;

namespace ABC148
{
    class A
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A + B == 3) Console.WriteLine(3);
            if (A + B == 4) Console.WriteLine(2);
            if (A + B == 5) Console.WriteLine(1);
        }
    }
}
