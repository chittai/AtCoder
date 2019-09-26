using System;

namespace ABC060
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            for (int i = 1; i <= A * B; i++)
            {
                if (i % A == 0 && i % B == C) { Console.WriteLine("YES"); return; }

            }
            Console.WriteLine("NO");
        }
    }
}
