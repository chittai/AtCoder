using System;

namespace ABC090
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int count = 0;
            string s;

            for (int i = A; i <= B; i++)
            {
                s = i.ToString();

                if (s[0] == s[s.Length - 1] && s[1] == s[s.Length - 2]) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
