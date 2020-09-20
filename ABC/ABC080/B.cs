using System;

namespace ABC080
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int n = N;
            int sum = 0;
            while (0 < n)
            {
                sum += n % 10;
                n = n / 10;
            }

            if (N % sum == 0) { Console.WriteLine("Yes"); } else { Console.WriteLine("No"); }

        }
    }
}
