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
            int res = 0;
            int n = N;
            for (int i = 0; i < len; i++)
            {
                int temp = n % 10;
                bool isDone = false;
                //Console.WriteLine(temp);
                for (int j = 0; j < D2.Length; j++)
                {
                    if (temp <= D2[j]) { res += D2[j] * (int)Math.Pow(10, i); isDone = true; break; }
                }

                if (!isDone) { res += D2[0] * (int)Math.Pow(10, i); }
                //Dに含まれていないで、各桁の値以上であり、とりうる最小の値を選択する(D2がその配列)
                n /= 10;
            }

            if (res < N && D2[0] != 0) { res += D2[0] * (int)Math.Pow(10, len); }
            else if (res < N && D2[0] == 0) { res = Math.Min(res * 10, res + D2[1] * (int)Math.Pow(10, len)); }

            Console.WriteLine(res);
        }
    }
}
