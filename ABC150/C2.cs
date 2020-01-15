using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC150
{
    class C2
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string P = string.Join("", Console.ReadLine().Split().ToArray());
            string Q = string.Join("", Console.ReadLine().Split().ToArray());

            var p = Permutation<int>.All(Enumerable.Range(1, N));

            long resP = 0;
            long resQ = 0;
            long index = 0;
            foreach (var item in p)
            {
                string s = string.Join("", item);
                if (s == P) resP = index;
                if (s == Q) resQ = index;
                index++;
            }
            Console.WriteLine(Math.Abs(resP - resQ));
        }

        static class Permutation<T>
        {
            private static void Search(List<T[]> perms, Stack<T> stack, T[] a)
            {
                int N = a.Length;
                if (N == 0)
                {
                    perms.Add(stack.Reverse().ToArray());
                }
                else
                {
                    var b = new T[N - 1];
                    Array.Copy(a, 1, b, 0, N - 1);
                    for (int i = 0; i < a.Length; ++i)
                    {
                        stack.Push(a[i]);
                        Search(perms, stack, b);
                        if (i < b.Length) { b[i] = a[i]; }
                        stack.Pop();
                    }
                }
            }
            public static IEnumerable<T[]> All(IEnumerable<T> src)
            {
                var perms = new List<T[]>();
                Search(perms, new Stack<T>(), src.ToArray());
                return perms;
            }
        }
    }
}
