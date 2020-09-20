using System;

namespace AGC038
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);
            int A = int.Parse(input[2]);
            int B = int.Parse(input[3]);

            if (W / 2 < A || H / 2 < B) { Console.WriteLine("No"); return; }

            int[,] s = new int[2, W];
            string a = "";
            string b = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < W; j++)
                {

                    if (i == 0)
                    {
                        if (j < W - A) a += "0";
                        else if (W - A <= j) a += "1";
                    }

                    if (i == 1)
                    {
                        if (j < W - A) b += "1";
                        else if (W - A <= j) b += "0";
                    }
                }
            }

            for (int i = 0; i < H; i++)
            {

                if (i < H - B) Console.WriteLine(a);
                else Console.WriteLine(b);
            }
        }
    }
}
