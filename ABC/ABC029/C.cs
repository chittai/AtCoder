using System;

namespace ABC029
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string s = "";
            brute(N, s);
        }

        static void brute(int n, string r)
        {
            if (n == 0)
            {
                Console.WriteLine(r);
                return;
            }
            brute(n - 1, r + 'a');
            brute(n - 1, r + 'b');
            brute(n - 1, r + 'c');
        }
    }
}
