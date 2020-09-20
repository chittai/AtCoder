using System;

namespace ABC083
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int A = int.Parse(input[1]);
            int B = int.Parse(input[2]);

            int sum = 0;
            int res = 0;
            int value = 0;
            for (int i = 1; i <= N; i++)
            {
                value = i;
                while (0 < value)
                {
                    sum += (value % 10);
                    value = (value / 10);
                }

                if (A <= sum && sum <= B)
                {
                    res += i;
                }
                sum = 0;
            }
            Console.WriteLine(res);
        }
    }
}
