using System;

namespace ABC070
{
    class B
    {
        static void Main(string[] args)
        {
            string[] intput = Console.ReadLine().Split();
            int A = int.Parse(intput[0]);
            int B = int.Parse(intput[1]);
            int C = int.Parse(intput[2]);
            int D = int.Parse(intput[3]);

            Console.WriteLine(Math.Max(0, Math.Min(B, D) - Math.Max(A, C)));
        }
    }
}
