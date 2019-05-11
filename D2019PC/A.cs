using System;
using System.Linq;

namespace D2019PC
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split(' ');
            int[] n = s.Select(x => int.Parse(x)).ToArray();

            int result = 0;

            result = n[0] - (n[1] - 1);

            Console.WriteLine(result);
        }
    }
}
