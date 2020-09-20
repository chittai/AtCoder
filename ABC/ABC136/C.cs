using System;

namespace ABC136
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] H = new int[N];
            for (int i = 0; i < N; i++)
            {
                H[i] = int.Parse(input[i]);
            }

            int temp = H[0];
            for (int i = 1; i < N; i++)
            {

                if (H[i] <= temp - 2)
                {
                    Console.WriteLine("No");
                    return;
                }

                if (temp < H[i])
                {
                    temp = H[i];
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
