using System;
using System.Linq;

namespace ABC125
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = Console.ReadLine().Split(' ');
            int[] an = a.Select(x => int.Parse(x)).ToArray();

            long result = 0;

            foreach (int x in an)
            {
                result += Math.Abs(x);
            }

            if (an.Count(x => x < 0) % 2 == 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                int min = Math.Abs(an[0]);
                for (int i = 0; i < an.Length; i++)
                {
                    if (Math.Abs(an[i]) < min) min = Math.Abs(an[i]);
                }
                result -= min * 2;
                Console.WriteLine(result);
            }
        }
    }
}
