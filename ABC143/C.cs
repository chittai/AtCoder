using System;
using System.Linq;

namespace ABC143
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            string S = Console.ReadLine() + ".";

            int count = 0;
            char temp;
            for (int i = 0; i < S.Length - 1; i++)
            {
                temp = S[i];

                while (i < S.Length - 1 && temp == S[i + 1])
                {
                    i++;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
