using System;
using System.Collections.Generic;

namespace D2019PC
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string s;
            int count = 0;
            int BconutA = 0;
            int conutA = 0;
            int Bconut = 0;
            int res = 0;

            for (int i = 0; i < N; i++)
            {
                count = 0;
                s = Console.ReadLine();

                if (s[0] == 'B' && s[s.Length - 1] == 'A') { BconutA++; }
                else if (s[0] == 'B') { Bconut++; }
                else if (s[s.Length - 1] == 'A') { conutA++; }

                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j] == 'A' && s[j + 1] == 'B') count++;
                }
                res += count;
            }


            while (1 < BconutA)
            {
                res++;
                BconutA--;
            }

            while (0 < BconutA)
            {
                if (Bconut == 0 || conutA == 0) break;
                BconutA--;
                Bconut--;
                conutA--;
                res += 2;
            }

            for (int i = 0; i < BconutA; i++)
            {
                if (Bconut < conutA) Bconut++;
                else conutA++;
            }

            Console.WriteLine(res + Math.Min(Bconut, conutA));
        }
    }
}
