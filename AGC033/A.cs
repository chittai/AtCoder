using System;
using System.Linq;
namespace AGC033
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int[] an = a.Select(x => int.Parse(x)).ToArray();

            string[] b = new string[an[0]];
            for (int i = 0; i < an[0]; i++)
            {
                b[i] = Console.ReadLine();
            }

            string[] blackposition = new string[an[0] * an[1]];
            string[] whiteposition = new string[an[0] * an[1]];

            int countb = 0;
            int countw = 0;
            for (int i = 0; i < an[0]; i++)
            {
                for (int j = 0; j < an[1]; j++)
                {
                    if (b[i][j] == '#')
                    {
                        blackposition[countb] = (i.ToString()) + (j.ToString());
                        //Console.WriteLine(blackposition[0][0]);
                        countb++;
                    }

                    if (b[i][j] == '.')
                    {
                        whiteposition[countw] = (i.ToString()) + (j.ToString());
                        countw++;
                    }
                }
            }

            int result = 0;

            int wx = 0;
            int wy = 0;

            int bx = 0;
            int by = 0;

            for (int i = 0; i < whiteposition.Length; i++)
            {
                if (whiteposition[i] != null)
                {
                    wx = (whiteposition[i][0] - '0');
                    wy = (whiteposition[i][1] - '0');

                }
                for (int j = 0; j < blackposition.Length; j++)
                {
                    if (blackposition[j] != null)
                    {
                        bx = (blackposition[j][0] - '0');
                        by = (blackposition[j][1] - '0');
                    }

                    if (Math.Abs(wx - bx) + Math.Abs(wy - by) > result)
                    {
                        result = Math.Abs(wx - bx) + Math.Abs(wy - by);
                    }

                }
            }
            Console.WriteLine(result);
        }

    }
}
