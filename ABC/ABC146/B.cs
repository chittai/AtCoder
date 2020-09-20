using System;
using System.Linq;

namespace ABC146
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            for (int i = 0; i < S.Length; i++)
            {
                if ('Z' < S[i] + N)
                {
                    Console.Write((char)(S[i] + N - 26));
                }
                else
                {
                    Console.Write((char)(S[i] + N));
                }
            }
            Console.WriteLine();
        }
    }
}
