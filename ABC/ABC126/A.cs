using System;
using System.Linq;

namespace ABC126
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int[] n1 = s1.Select(x => int.Parse(x)).ToArray();

            string s2 = Console.ReadLine();

            string s3 = "";
            for (int i = 0; i < n1[0]; i++)
            {
                if (i == n1[1] - 1)
                {
                    s3 += char.ToLower(s2[i]);
                }
                else
                {
                    s3 += s2[i];
                }
            }

            Console.WriteLine(s3);
        }
    }
}
