using System;
using System.Linq;

namespace ABC132
{
    class A
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            foreach (var c in s)
            {
                int count = s.Where(x => x == c).Count();
                if ((count % 2) != 0 || (count / 2) == 2)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
