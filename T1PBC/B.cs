using System;
using System.Linq;

namespace T1PBC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            int k = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (char c in s)
            {
                if (c != s[k - 1])
                    s[count] = '*';
                count++;
            }
            Console.WriteLine(s);
        }
    }
}
