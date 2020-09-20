using System;
using System.Linq;

namespace ABC051
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sx = input[0];
            int sy = input[1];
            int tx = input[2];
            int ty = input[3];

            string s = "";
            for (int i = 0; i < 2; i++)
            {

                for (int u = 0; u < Math.Abs(sy - ty); u++)
                {
                    s += "U";
                }

                for (int r = 0; r < Math.Abs(sx - tx); r++)
                {
                    s += "R";
                }
                if (i == 1) s += "DR";

                for (int d = 0; d < Math.Abs(sy - ty); d++)
                {
                    s += "D";
                }

                for (int l = 0; l < Math.Abs(sx - tx); l++)
                {
                    s += "L";
                }
                if (i == 1) s += "U";

                if (i == 0)
                {
                    s += "L";
                    tx++;
                    ty++;
                }
            }
            Console.WriteLine(s);
        }
    }
}
