using System;
using System.Linq;

namespace ABC145
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            if (S.Length % 2 != 0) { Console.WriteLine("No"); return; }

            string s1 = S.Substring(0, S.Length / 2);
            string s2 = S.Substring(S.Length / 2, S.Length / 2);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            if (s1 == s2) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }

        }
    }
}
