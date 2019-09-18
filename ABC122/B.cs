using System;

namespace ABC122
{
    class B
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int count = 0;
            int tmp = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'A' || S[i] == 'C' || S[i] == 'G' || S[i] == 'T')
                {
                    tmp++;
                }
                else
                {
                    tmp = 0;
                }
                count = Math.Max(count, tmp);
            }
            Console.WriteLine(count);
        }
    }
}
