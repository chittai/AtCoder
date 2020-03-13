using System;
using System.IO;
using System.Linq;

namespace ABC107
{
    class B
    {
        static void Main(string[] args)
        {
            var HW = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var hw = Enumerable.Repeat(0, HW[0]).Select(_ => Console.ReadLine()).ToArray();

            var resH = new int[HW[0]];
            var resW = new int[HW[1]];
            var isblack = false;
            for (int h = 0; h < HW[0]; h++)
            {
                isblack = false;
                for (int w = 0; w < HW[1]; w++)
                {
                    if (hw[h][w] == '#') isblack = true;
                }
                if (!isblack) resH[h] = 1;
            }

            for (int w = 0; w < HW[1]; w++)
            {
                isblack = false;
                for (int h = 0; h < HW[0]; h++)
                {
                    if (hw[h][w] == '#') isblack = true;
                }
                if (!isblack) resW[w] = 1;
            }

            for (int h = 0; h < HW[0]; h++)
            {
                if (resH[h] == 1) continue;
                for (int w = 0; w < HW[1]; w++)
                {
                    if (resW[w] == 1) continue;
                    Console.Write(hw[h][w]);
                }
                Console.WriteLine();
            }
        }
    }
}
