using System;

namespace ABC129
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int[] n = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                n[i] = int.Parse(input[i]);
            }

            Array.Sort(n);

            Console.WriteLine(n[0] + n[1]);
        }
    }
}
