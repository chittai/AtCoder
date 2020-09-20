using System;

namespace ABC130
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int X = int.Parse(input[0]);
            int A = int.Parse(input[1]);

            if (X < A) { Console.WriteLine(0); } else { Console.WriteLine(10); }
        }
    }
}
