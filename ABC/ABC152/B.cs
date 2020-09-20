using System;
using System.Linq;

namespace ABC152
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];

            if (a <= b)
            {
                for (int i = 0; i < (int)b; i++)
                {
                    Console.Write(a);
                }
            }
            else
            {
                for (int i = 0; i < (int)a; i++)
                {
                    Console.Write(b);
                }
            }
            Console.WriteLine();
        }
    }
}
