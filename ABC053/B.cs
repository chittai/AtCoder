using System;

namespace ABC053
{
    class B
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;
            int a = 0;
            bool isFirst = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A' && isFirst) { a = i; isFirst = false; }
                if (s[i] == 'Z') { count = (i - a) + 1; }
            }
            Console.WriteLine(count);
        }
    }
}
