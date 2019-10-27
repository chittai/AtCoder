using System;
using System.Linq;

namespace ABC144
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (N == i * j) { Console.WriteLine("Yes"); return; }
                }
            }
            Console.WriteLine("No");
        }
    }
}
