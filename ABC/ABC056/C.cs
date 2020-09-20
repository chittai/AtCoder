using System;

namespace ABC056
{
    class C
    {
        static void Main(string[] args)
        {
            long X = long.Parse(Console.ReadLine());

            long sum = 0;
            int t = 0;
            for (int i = 1; ; i++)
            {
                t = i;
                sum += i;
                if (X <= sum) break;
            }

            Console.WriteLine(t);
        }
    }
}
