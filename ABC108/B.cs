using System;
using System.Linq;
 
namespace ABC108
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = input[2] - input[0];
            int y = input[3] - input[1];
 
            Console.WriteLine("{0} {1} {2} {3}", input[2] - y, input[3] + x, input[0] - y, input[1] + x);
 
        }
    }
}
