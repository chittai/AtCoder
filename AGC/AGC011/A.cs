using System;

namespace AGC011
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int C = int.Parse(input[1]);
            int K = int.Parse(input[2]);

            int[] T = new int[N];

            for (int i = 0; i < T.Length; i++)
            {
                T[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(T);

            int busCount = 0;
            int passengerCount = 0;
            int index = 0;

            for (int i = 0; i < N; i++)
            {
                passengerCount++;

                if (i == N - 1 || passengerCount == C || T[index] + K < T[i + 1])
                {
                    busCount++;
                    index = i + 1;
                    passengerCount = 0;
                }
            }
            Console.WriteLine(busCount);
        }
    }
}
