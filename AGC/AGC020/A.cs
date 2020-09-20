using System;

namespace AGC020
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int A = int.Parse(input[1]);
            int B = int.Parse(input[2]);
            if ((B - A - 1) % 2 != 0) Console.WriteLine("Alice");
            if ((B - A - 1) % 2 == 0) Console.WriteLine("Borys");
        }
    }
}
