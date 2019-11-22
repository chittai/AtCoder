using System;
using System.Linq;

namespace ARC031
{
    class B
    {
        static char[,] hw;
        static int num = 0;
        static int H = 10;
        static int W = 10;

        static void Main(string[] args)
        {
            hw = new char[W, H];
            for (int h = 0; h < H; h++)
            {
                string S = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    hw[w, h] = S[w];
                }
            }

            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    if (hw[w, h] == 'o')
                    {
                        num++;
                        DFS(w, h);
                    }
                }
            }


            /*
            for (int h = 0; h < H; h++)
            {
                for (int w = 0; w < W; w++)
                {
                    Console.Write(hw[w, h]);
                }
                Console.WriteLine();
            }
            */


            string res = "";
            for (int i = 1; i <= num; i++)
            {
                res += i.ToString();
            }
            for (int h = 0; h < H; h++)
            {
                string sum = "";
                for (int w = 0; w < W; w++)
                {
                    sum = "";
                    if (hw[w, h] == 'x')
                    {
                        if (w + 1 < W && hw[w + 1, h] != 'x') sum += hw[w + 1, h].ToString();
                        if (0 <= w - 1 && hw[w - 1, h] != 'x') sum += hw[w - 1, h].ToString();
                        if (h + 1 < H && hw[w, h + 1] != 'x') sum += hw[w, h + 1].ToString();
                        if (0 <= h - 1 && hw[w, h - 1] != 'x') sum += hw[w, h - 1].ToString();
                    }
                    var sumarray = sum.OrderBy(x => x).ToArray().Distinct();
                    sum = string.Join("", sumarray);

                    //Console.WriteLine(sum);
                    if (res == sum) { Console.WriteLine("YES"); return; }
                }
            }
            Console.WriteLine("NO");
        }

        static void DFS(int x, int y)
        {
            if (hw[x, y] != 'o') { return; }
            hw[x, y] = (char)('0' + num);

            if (x + 1 < W) DFS(x + 1, y);
            if (0 <= x - 1) DFS(x - 1, y);
            if (y + 1 < H) DFS(x, y + 1);
            if (0 <= y - 1) DFS(x, y - 1);
        }
    }
}
