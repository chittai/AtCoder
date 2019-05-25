using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC127
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = s.Select(x => int.Parse(x)).ToArray();

            var s1 = new List<string>();
            for (int i = 0; i < n[1]; i++)
            {
                s1.Add(Console.ReadLine());
            }

            string[] s4;
            int result;
            int result2 = 0;
            int nmin;
            int nmax;
            for (int i = 1; i <= n[0]; i++)
            {
                result = 0;
                foreach (string s3 in s1)
                {
                    s4 = s3.Split(' ');
                    nmin = int.Parse(s4[0]);
                    nmax = int.Parse(s4[1]);

                    if (nmin <= i && i <= nmax)
                        result++;
                    else
                        break;
                    if (result == n[1]) result2++;
                }

                Console.WriteLine(i);
            }
            Console.WriteLine(result2);
        }
    }
}