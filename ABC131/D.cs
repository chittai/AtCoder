using System;
using System.Collections;
using System.Linq;

namespace ABC131
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input;

            long[][] AB = new long[N][];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split();
                AB[i] = new long[] { int.Parse(input[1]), int.Parse(input[0]) };
            }

            Array.Sort(AB, StructuralComparisons.StructuralComparer);

            long count = 0;
            foreach (var item in AB)
            {
                count += item[1];
                if (item[0] < count) { Console.WriteLine("No"); return; }
            }

            Console.WriteLine("Yes");

            /*
            Console.WriteLine("-----");
            foreach (var item in AB)
            {
                Console.Write(item[0]);
                Console.Write(' ');
                Console.Write(item[1]);
                Console.WriteLine();
            }
            */
        }
    }
}
