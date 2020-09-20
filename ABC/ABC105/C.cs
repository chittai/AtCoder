using System;
using System.Linq;

namespace ABC105
{
    class C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            var ans = "";
            if (N == 0) ans = "0";
            while (N != 0)
            {
                if (N % 2 != 0)
                {
                    N--;
                    ans = "1" + ans;
                }
                else
                {
                    ans = "0" + ans;
                }
                N /= -2;
            }
            Console.WriteLine(ans);
        }
    }
}
