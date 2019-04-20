using System;
using System.Linq;

namespace T1PBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dist = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            if (Math.Min(dist[0], dist[1]) < dist[2] && dist[2] < Math.Max(dist[0], dist[1]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
