using System;
using System.Linq;

namespace ABC064
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            int need_left = 0;
            int need_right = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(') need_right++;
                else
                {
                    if (0 < need_right) need_right--;
                    else need_left++;
                }
            }

            string res = "";
            for (int i = 0; i < need_left; i++) res += '(';
            res += S;
            for (int i = 0; i < need_right; i++) res += ')';

            Console.WriteLine(res);

        }
    }
}