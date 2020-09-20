using System;
using System.Linq;

namespace ABC042
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            int[] D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] D2 = Enumerable.Range(0, 10).Where(x => !D.Contains(x)).ToArray();

            //Console.WriteLine(string.Join(",", D2));
            //Console.WriteLine(N.ToString().Length);

            //Nの桁数回繰り返す
            int len = N.ToString().Length;
            //int res = 0;
            int n = 0;

            for (int i = N; i < 10 * N; i++)
            {
                bool isOK = true;
                n = i;
                string s = n.ToString();
                for (int j = 0; j < s.ToString().Length; j++)
                {
                    if (D.Contains(int.Parse(s[j].ToString()))) { isOK = false; break; }
                }
                if (isOK) break;
            }
            Console.WriteLine(n);
        }
    }
}
