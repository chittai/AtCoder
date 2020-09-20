using System;
using System.Linq;

namespace MSPC
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if (8 <= s.Count(x => x == 'x'))
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
