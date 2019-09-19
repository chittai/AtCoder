using System;
using System.Linq;

namespace ABC064
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] a = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                a[i] = int.Parse(input[i]);
            }

            int max = a.Max();
            int min = a.Min();

            Console.WriteLine(max - min);
        }
    }
}