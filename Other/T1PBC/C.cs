using System;
using System.Linq;

namespace T1PBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int Rwhite = s.Count(x => x == '.');
            int RBlack = s.Count(x => x == '#');

            int LBlack = 0;

            int result = Rwhite + LBlack;
            for (int i = 0; i < input; i++)
            {
                if (s[i] == '.')
                {
                    Rwhite--;
                }
                else
                {
                    LBlack++;
                }

                if ((LBlack + Rwhite) < result)
                {
                    result = LBlack + Rwhite;
                }

            }
            Console.WriteLine(result);
        }
    }
}