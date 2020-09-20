using System;

namespace ABC141
{
    class B
    {
        static void Main(string[] args)
        {

            string S = Console.ReadLine();

            bool isFumiyasui = true;
            for (int i = 0; i < S.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    if (S[i] == 'L')
                    {
                        isFumiyasui = false;
                    }
                }

                if ((i % 2) == 1)
                {
                    if (S[i] == 'R')
                    {
                        isFumiyasui = false;
                    }
                }
            }

            if (isFumiyasui)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
