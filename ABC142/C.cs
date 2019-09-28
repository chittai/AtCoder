using System;
using System.Linq;

namespace ABC142
{
    class C
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] res = new int[N];
            for (int i = 0; i < N; i++)
            {
                res[a[i] - 1] = i + 1;
            }

            foreach (var item in res)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
