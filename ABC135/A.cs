using System;

namespace ABC135
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if ((A + B) % 2 == 0)
            {
                Console.WriteLine((A + B) / 2);
            }
            else
            {
                Console.WriteLine("IMPOSSIBLE");
            }
        }
    }
}
