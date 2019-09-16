using System;
using System.Linq;

namespace ABC141
{
    class D
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            double[] A = new double[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(input[i]);
            }



            for (int i = 0; i < M; i++)
            {
                A = A.OrderByDescending(x => x).ToArray();
                A[0] = (Math.Floor(A[0] * (0.5)));
            }

            double sum = 0;
            foreach (var x in A)
            {
                sum += x;
            }

            Console.WriteLine(sum);

            //foreach (var i in A) { Console.WriteLine(i); }
            //Console.WriteLine(Math.Floor(5 * (0.5)));

        }
    }
}
