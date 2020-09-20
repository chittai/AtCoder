using System;

namespace ABC069
{
    class B
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.Write(s[0]);
            Console.Write(s.Length - 2);
            Console.WriteLine(s[s.Length - 1]);
        }
    }
}
