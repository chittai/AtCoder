using System;

namespace ABC136
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            if (C - (A - B) <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                Console.WriteLine(C - (A - B));
            }
        }
    }
}
