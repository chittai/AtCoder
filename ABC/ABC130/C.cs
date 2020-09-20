using System;

namespace ABC130
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double W = double.Parse(input[0]);
            double H = double.Parse(input[1]);
            double x = double.Parse(input[2]);
            double y = double.Parse(input[3]);

            if ((W % 2) == 0 && (H % 2) == 0)
            {
                if (x == (W / 2) && y == (H / 2))
                {
                    Console.Write((W * H) / 2);
                    Console.Write(' ');
                    Console.WriteLine(1);
                    return;
                }
            }
            Console.Write((W * H) / 2);
            Console.Write(' ');
            Console.WriteLine(0);
        }
    }
}
