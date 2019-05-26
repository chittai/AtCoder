using System;
using System.Linq;

namespace ABC128
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int P = int.Parse(s[1]);

            int pieP = P / 2;
            int pieP2 = P % 2;

            int pieA = (A * 3 + pieP2) / 2;

            int result = pieA + pieP;
            Console.WriteLine(result);
        }
    }
}
