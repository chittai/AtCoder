using System;

namespace ABC120
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            if (B / A < C) Console.WriteLine(B / A);
            else Console.WriteLine(C);
        }
    }
}
