using System;
using System.Linq;

namespace ABC125
{
    class B
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] v = Console.ReadLine().Split(' ');
            int[] vn = v.Select(x => int.Parse(x)).ToArray();

            string[] c = Console.ReadLine().Split(' ');
            int[] cn = c.Select(x => int.Parse(x)).ToArray();

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (0 <= (vn[i] - cn[i]))
                    result += (vn[i] - cn[i]);
            }

            Console.WriteLine(result);
        }
    }
}
