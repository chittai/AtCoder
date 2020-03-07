using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC158
{
    class C
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine().ToList();
            var Q = long.Parse(Console.ReadLine());

            var Mae = new List<char>();
            var Ushiro = new List<char>();

            var onecount = 0;
            for (int i = 0; i < Q; i++)
            {
                var q = Console.ReadLine().Split().ToArray();
                if (long.Parse(q[0]) == 1) onecount++;
                else
                {
                    var f = q[1];
                    var c = q[2].ToCharArray();
                    if (onecount % 2 == 0)
                    {
                        if (long.Parse(f) == 1)
                        {
                            Mae.Add(c[0]);
                        }
                        else
                        {
                            Ushiro.Add(c[0]);
                        }
                    }
                    else
                    {
                        if (long.Parse(f) == 1)
                        {
                            Ushiro.Add(c[0]);
                        }
                        else
                        {
                            Mae.Add(c[0]);

                        }
                    }
                }

            }
            if (onecount % 2 == 0)
            {

                for (int i = Mae.Count - 1; i >= 0; i--)
                {
                    Console.Write(Mae[i]);
                }

                for (int i = 0; i < S.Count; i++)
                {
                    Console.Write(S[i]);
                }

                for (int i = 0; i < Ushiro.Count; i++)
                {
                    Console.Write(Ushiro[i]);
                }
            }
            else
            {
                for (int i = Ushiro.Count - 1; i >= 0; i--)
                {
                    Console.Write(Ushiro[i]);
                }

                for (int i = S.Count - 1; i >= 0; i--)
                {
                    Console.Write(S[i]);
                }

                for (int i = 0; i < Mae.Count; i++)
                {
                    Console.Write(Mae[i]);
                }

            }
            Console.WriteLine();

        }
    }
}
