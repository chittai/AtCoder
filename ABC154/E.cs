using System;
using System.Linq;

namespace ABC154
{
    class E
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());

            long res = 0;
            if (K == 1)
            {
                res += N[0] - '0';
                res += 9 * (N.Length - 1);
            }
            else if (K == 2)
            {
                for (int i = 0; i < N.Length - 1; i++)
                {
                    for (int j = i + 1; j < N.Length; j++)
                    {

                    }

                }
            }



            Console.WriteLine(res);

        }
    }
}
