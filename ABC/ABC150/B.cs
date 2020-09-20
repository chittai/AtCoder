using System;
using System.Linq;

namespace ABC150
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            int res = 0;
            for (int i = 0; i < N - 3 + 1; i++)
            {
                string tmp = S[i].ToString() + S[i + 1].ToString() + S[i + 2].ToString();
                if (tmp == "ABC") res++;
            }
            Console.WriteLine(res);
        }
    }
}
