using System;
using System.Linq;

namespace ABC095
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int X = int.Parse(input[1]);

            int min = int.MaxValue;
            int m = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                m = int.Parse(Console.ReadLine());
                X -= m;
                count++;
                min = Math.Min(min, m);
            }

            Console.WriteLine(count + X / min);
        }
    }
}
