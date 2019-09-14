using System;
using System.Linq;

namespace ABC124.B
{
    class B
    {
        static void Main(string[] args)
        {
            string mountains = Console.ReadLine();
            string[] height = Console.ReadLine().Split(' ');

            int intMountains = int.Parse(mountains);
            int[] intHeigt = height.Select(int.Parse).ToArray();

            int minHeight = intHeigt[0];
            int count = 0;

            foreach (int h in intHeigt)
            {
                if (h >= minHeight)
                {
                    minHeight = h;
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}