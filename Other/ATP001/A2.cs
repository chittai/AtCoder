using System;
using System.Collections.Generic;
using System.Linq;

namespace ATP001
{
    class A2
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];

            char[,] c = new char[W, H];
            int sx = 0;
            int sy = 0;
            for (int h = 0; h < H; h++)
            {
                string s = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    c[w, h] = s[w];
                    if (s[w] == 's') { sx = w; sy = h; }
                }
            }

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            Tuple<int, int> tupleS = Tuple.Create(sx, sy);
            stack.Push(tupleS);

            bool isOK = false;
            while (0 < stack.Count)
            {
                var t = stack.Pop();
                if (c[t.Item1, t.Item2] == 'g') { isOK = true; }
                c[t.Item1, t.Item2] = '#';

                if (t.Item1 + 1 < W && c[t.Item1 + 1, t.Item2] != '#') { stack.Push(Tuple.Create(t.Item1 + 1, t.Item2)); }
                if (0 <= t.Item1 - 1 && c[t.Item1 - 1, t.Item2] != '#') { stack.Push(Tuple.Create(t.Item1 - 1, t.Item2)); }
                if (t.Item2 + 1 < H && c[t.Item1, t.Item2 + 1] != '#') { stack.Push(Tuple.Create(t.Item1, t.Item2 + 1)); }
                if (0 <= t.Item2 - 1 && c[t.Item1, t.Item2 - 1] != '#') { stack.Push(Tuple.Create(t.Item1, t.Item2 - 1)); }
            }
            if (isOK) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
