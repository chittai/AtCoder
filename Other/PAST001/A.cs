using System;

namespace PAST001
{
    class A
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int x = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (!int.TryParse(S, out x)) { Console.WriteLine("error"); return; }
            }
            Console.WriteLine(int.Parse(S) * 2);
        }
    }
}
