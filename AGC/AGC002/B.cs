using System;
using System.Linq;

namespace AGC002
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            //ballの数を持つ配列
            int[] Num = new int[N].Select(x => 1).ToArray();
            //Console.WriteLine(string.Join(",", Num));

            //赤が入っている可能性があるか判断するための配列
            bool[] Red = new bool[N];

            //T -> F へ移動したときに、 F -> T へと変更する(移動時はballの数をマイナスする)
            //最初Tだったとしても、ballの数が0個になった時、T -> F へと変更する
            Red[0] = true;

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = input[0] - 1;
                int y = input[1] - 1;

                Num[x]--;
                Num[y]++;

                if (Red[x] == true) { Red[y] = true; }
                if (Num[x] == 0) Red[x] = false;
            }

            long sum = Red.Count(x => x == true);

            Console.WriteLine(sum);
        }
    }
}
