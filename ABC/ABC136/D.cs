using System;

namespace ABC136
{
    class D
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            long[] res = new long[S.Length];
            long r = 0;
            long l = 0;

            int indexR = 0;
            int indexL = 0;

            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] == 'R') r++;
                if (S[i] == 'L') l++;

                if (i + 1 == S.Length - 1) { l++; }

                if (S[i] == 'R' && S[i + 1] == 'L')
                {
                    indexR = i;
                    indexL = i + 1;
                }

                if ((S[i] == 'L' && S[i + 1] == 'R') || i + 1 == S.Length - 1)
                {
                    if ((r + l) % 2 == 0)
                    {
                        res[indexR] = (r + l) / 2;
                        res[indexL] = (r + l) / 2;
                    }
                    else if ((r + l) % 2 != 0)
                    {
                        if (r <= l && l % 2 == 0)
                        {
                            res[indexR] = (r + l) / 2 + 1;
                            res[indexL] = (r + l) / 2;
                        }
                        else if (r <= l && l % 2 == 1)
                        {
                            res[indexR] = (r + l) / 2;
                            res[indexL] = (r + l) / 2 + 1;
                        }


                        if (l <= r && r % 2 == 0)
                        {
                            res[indexR] = (r + l) / 2;
                            res[indexL] = (r + l) / 2 + 1;
                        }
                        else if (l <= r && r % 2 == 1)
                        {
                            res[indexR] = (r + l) / 2 + 1;
                            res[indexL] = (r + l) / 2;
                        }
                    }

                    r = 0;
                    l = 0;

                }
            }

            foreach (var item in res)
            {
                Console.Write(item);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
