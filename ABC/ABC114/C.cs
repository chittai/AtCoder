using System;
using System.Linq;

namespace ABC114
{
    class C
    {
        static int res = 0;
        static long N = 0;
        static void Main(string[] args)
        {
            N = long.Parse(Console.ReadLine());
            // dfsの呼び出し
            dfs("0");
            Console.WriteLine(res);
        }

        static void dfs(string s)
        {
            if (long.Parse(s) > N) return;

            if (0 < s.Count(x => x == '7') && 0 < s.Count(x => x == '5') && 0 < s.Count(x => x == '3'))
            {
                res++;
            }

            foreach (char c in "753")
            {
                dfs(s + c);
            }
        }


    }
}
