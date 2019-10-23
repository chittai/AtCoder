using System;
using System.Linq;

namespace ABC110
{
    class C
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            int[] start = new int[26].Select(x => -1).ToArray();
            int[] goal = new int[26].Select(x => -1).ToArray();

            for (int i = 0; i < S.Length; i++)
            {
                int a = S[i] - 'a';
                int b = T[i] - 'a';

                if (start[a] != -1 || goal[b] != -1)
                {
                    if (start[a] != b || goal[b] != a)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                start[a] = b;
                goal[b] = a;
            }
            Console.WriteLine("Yes");
        }
    }
}
