using System;
using System.Linq;

namespace ABC152
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input[0] == input[1]) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}
