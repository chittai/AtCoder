using System;

namespace ABC133
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int A = int.Parse(input[1]);
            int B = int.Parse(input[2]);

            if (N * A <= B)
            {
                Console.WriteLine(N * A);
            }
            else
            {
                Console.WriteLine(B);
            }
        }
    }
}
