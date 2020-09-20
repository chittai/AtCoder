using System;
using System.IO;
using System.Linq;

namespace AGC040
{
    class A
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"./testcase/in/A/testcase1");
            string S = sr.ReadLine();
            //string S = Console.ReadLine();
            long[] res = new long[S.Length + 1];
            long index = 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '<') { res[i + 1] = index; index++; }
                else { index = 1; }
            }

            index = 1;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '>') { res[i] = Math.Max(res[i], index); index++; }
                else { index = 1; }
            }

            long sum = 0;
            sum = res.Sum();
            /*
            for (long i = 0; i < S.Length + 1; i++)
            {
                sum += res[i];
            }
             */

            Console.WriteLine(sum);

        }
    }
}
