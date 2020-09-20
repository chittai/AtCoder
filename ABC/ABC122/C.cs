using System;

namespace ABC122
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int Q = int.Parse(input[1]);

            string S = Console.ReadLine();

            int[] a = new int[S.Length];
            int[] s = new int[S.Length + 1];
            int count = 0;
            a[0] = 0;
            s[0] = 0;

            for (int i = 1; i < S.Length; i++)
            {
                if (S[i - 1] == 'A' && S[i] == 'C') { count++; }
                a[i] = count;
                s[i] += a[i - 1];
            }
            s[S.Length] += a[S.Length - 1];

            int l = 0;
            int r = 0;
            int[] res = new int[Q];
            for (int i = 0; i < Q; i++)
            {
                input = Console.ReadLine().Split(' ');
                l = int.Parse(input[0]);
                r = int.Parse(input[1]);

                res[i] = s[r] - s[l];
            }

            foreach (var item in res) { Console.WriteLine(item); }
        }
    }
}
