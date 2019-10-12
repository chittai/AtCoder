using System;
using System.IO;
using System.Linq;

namespace AGC034
{
    class B
    {
        static void Main(string[] args)
        {

            //StreamReader sr = new StreamReader(@"testcase");
            //string s = sr.ReadLine();
            string s = Console.ReadLine();
            s = s.Replace("BC", "D");
            string[] S = s.Select(x => x.ToString()).ToArray();
            long dcount = 0;
            long res = 0;

            // TLE
            /*
            for (int i = S.Length - 2; i >= 0; i--)
            {
                if (S[i] == "A")
                {
                    index = i + 1;
                    while (index < S.Length && S[index] == "D")
                    {
                        index++;
                        count++;
                    }

                    if (0 < count)
                    {
                        S[i] = "D";
                        S[index - 1] = "A";
                    }
                    res += count;
                }
                count = 0;
            }
             */

            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == "A")
                {
                    res += dcount;
                }
                else if (0 < i && S[i] == "D" && (S[i - 1] == "D" || S[i - 1] == "A"))
                {
                    dcount++;
                }
                else
                {
                    dcount = 0;
                }
            }
            Console.WriteLine(res);
        }
    }
}