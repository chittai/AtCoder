using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC134
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] b = new int[N + 1];
            for (int i = N; 0 < i; i--)
            {
                int count = 0;
                int j = 1;
                while (i * j <= N)
                {
                    count += b[i * j];
                    j++;
                }

                if (count % 2 != a[i - 1]) { b[i] = 1; }
                else { b[i] = 0; }
            }

            List<int> list = new List<int>();
            int index = 0;
            foreach (var item in b)
            {
                if (item == 1) { list.Add(index); }
                index++;
            }

            Console.WriteLine(list.Count());
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            if (list.Count != 0) Console.WriteLine();
        }
    }
}
