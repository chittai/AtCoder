using System;
using System.Linq;

namespace AGC034
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int A = input[1] - 1;
            int B = input[2] - 1;
            int C = input[3] - 1;
            int D = input[4] - 1;
            string s = Console.ReadLine();

            if (C < D || C < B)
            {
                int index = B;
                int goal = D;
                int count = 0;
                while (count < 2)
                {
                    while (index < goal)
                    {
                        if (index + 2 < s.Length && s[index + 2] == '.') { index += 2; }
                        else if (index + 1 < s.Length && s[index + 1] == '.') { index += 1; }
                        else { Console.WriteLine("No"); return; }
                    }
                    count++;
                    index = A;
                    goal = C;
                }
                Console.WriteLine("Yes");
            }
            else
            {
                for (int i = B; i <= D; i++)
                {
                    if (i + 1 < s.Length && s[i - 1] == '.' && s[i] == '.' && s[i + 1] == '.') { Console.WriteLine("Yes"); return; }
                }
                Console.WriteLine("No");
            }
        }
    }
}