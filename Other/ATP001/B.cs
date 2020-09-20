using System;
using System.Collections.Generic;
using System.Linq;

namespace ATP001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int Q = input[1];

            UF uf = new UF(N);
            List<bool> list = new List<bool>();

            for (int i = 0; i < Q; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (input[0] == 0)
                {
                    uf.Unite(input[1], input[2]);
                }
                else if (input[0] == 1)
                {
                    if (uf.CheckSame(input[1], input[2]))
                    {
                        list.Add(true);
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", uf.parent));

            foreach (var item in list)
            {
                Console.WriteLine(item ? "Yes" : "No");
            }

        }
    }

    class UF
    {
        public int[] p { get; }
        public int[] parent;
        public UF(int N) { parent = Enumerable.Range(0, N).ToArray(); }

        int root(int x)
        {
            if (parent[x] == x) return x;
            return parent[x] = root(parent[x]);
        }

        public void Unite(int x, int y)
        {
            int rx = root(x);
            int ry = root(y);
            if (rx == ry) return;
            parent[rx] = ry;
        }
        public bool CheckSame(int x, int y)
        {
            int rx = root(x);
            int ry = root(y);
            return rx == ry;
        }
    }
}
