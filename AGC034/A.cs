using System;
using System.Linq;

namespace AGC034
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int A = int.Parse(s[1]);
            int B = int.Parse(s[2]);
            int C = int.Parse(s[3]);
            int D = int.Parse(s[4]);

            string s1 = Console.ReadLine();
            /*
                        if (s1[C - 1] == '#' || s1[D - 1] == '#')
                        {
                            Console.WriteLine("No");
                            return;
                        }
             */
            if (B < C && C < D)
            {
                var result1 = HaveTwoSharp(s1, A, C);
                var result2 = HaveTwoSharp(s1, B, D);

                if (!result1 && !result2)
                {
                    Console.WriteLine("Yes");
                    return;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            if (C < B && C < D)
            {
                var result1 = HaveTwoSharp(s1, A, C);
                var result2 = HaveTwoSharp(s1, B, D);

                if (!result1 && !result2)
                {
                    Console.WriteLine("Yes");
                    return;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            if (D < C)
            {
                var result1 = HaveTwoSharp(s1, A, C);
                var result2 = HaveTwoSharp(s1, B, D);
                var result3 = HaveThreeDot(s1, B, D);
                //var result4 = HaveDotBD(s1, B);
                //var result5 = HaveDotBD(s1, D);

                if (!result1 && !result2 && result3)
                {
                    Console.WriteLine("Yes");
                    return;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
        }

        static bool HaveTwoSharp(string s, int start, int end)
        {
            char[] c = s.Skip(start - 1).Take(end - start + 1).ToArray();
            string s2 = new string(c);
            return s2.Contains("##");
        }

        static bool HaveThreeDot(string s, int start, int end)
        {
            char[] c = s.Skip(start - 1).Take(end - start + 2).ToArray();
            string s2 = new string(c);
            return s2.Contains("...");
        }

        static bool HaveDotBD(string s, int end)
        {
            var c1 = s[end - 1];
            var c2 = s[end - 2];
            var c3 = s[end];

            Console.WriteLine("c1" + c1);
            Console.WriteLine("c2" + c2);
            Console.WriteLine("c3" + c3);

            if (c1 == '.' && c2 == '.' && c3 == '.')
                return true;
            else
                return false;
        }
    }
}