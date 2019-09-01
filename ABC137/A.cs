using System;
using System.Linq;

namespace ABC137
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int[] n = new int[] { A + B, A - B, A * B };
            int res = n.Max();

            Console.WriteLine(res);
        }
    }
}
