using System;
using System.Linq;

namespace MSBPC2019
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M1 = input1[0];
            int D1 = input1[1];
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M2 = input2[0];
            int D2 = input2[1];

            if (M1 + 1 == M2 || (M1 == 12 && M2 == 1)) { Console.WriteLine(1); }
            else { Console.WriteLine(0); }
        }
    }
}
