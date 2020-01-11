using System;
using System.Linq;

namespace DOWANGO006
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] s = new string[N];
            int[] t = new int[N];
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                s[i] = input[0];
                t[i] = int.Parse(input[1]);
            }
            string X = Console.ReadLine();
            int sum = 0;
            int total = t.Sum();
            for (int i = 0; i < N; i++)
            {
                sum += t[i];
                if (s[i] == X) break;
            }
            Console.WriteLine(total - sum);
        }
    }
}
