using System;
using System.Linq;

namespace ABC125
{
    class C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] a = Console.ReadLine().Split(' ');
            int[] an = a.Select(x => int.Parse(x)).ToArray();

            int result = 0;
            for (int i = 0; i < n - 1; i++)
            {
                var gcd = Gcd(an[i], an[i + 1]);
                if (result <= gcd) result = gcd;
            }

            Console.WriteLine(result);
        }

        public static int Gcd(int a, int b)
        {
            if (a < b)
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
