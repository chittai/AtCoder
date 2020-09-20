using System;
using System.Linq;

namespace ABC143
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int N = int.Parse(Console.ReadLine());
            //string S = Console.ReadLine();
            int A = input[0];
            int B = input[1];
            int sum = A - 2 * B;
            if (0 < sum) Console.WriteLine(sum);
            else Console.WriteLine(0);
        }
    }
}
