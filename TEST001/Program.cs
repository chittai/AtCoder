using System;
using System.Linq;

namespace TEST001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine((char)(input[0] + '0'));



        }
    }
}
