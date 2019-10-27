using System;
using System.Linq;

namespace ARC015
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double MT = 0, mT = 0;
            double[] input = new double[2];
            int[] Res = new int[6];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                MT = input[0];
                mT = input[1];

                if (35 <= MT) { Res[0]++; }
                else if (30 <= MT && MT < 35) { Res[1]++; }
                else if (25 <= MT && MT < 30) { Res[2]++; }

                if (25 <= mT) { Res[3]++; }
                else if (mT < 0 && 0 <= MT) { Res[4]++; }
                else if (MT < 0) { Res[5]++; }
            }
            Console.WriteLine(string.Join(" ", Res));
        }
    }
}
