using System;

namespace ABC114
{
    class A
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            if (X == 3 || X == 5 || X == 7) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
