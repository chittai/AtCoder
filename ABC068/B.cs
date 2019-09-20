using System;

namespace ABC068
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double res = 0;
            int i = 0;
            while (res <= N)
            {
                res = Math.Pow(2, i);
                i++;
            }
            Console.WriteLine(res / 2);
        }
    }
}
