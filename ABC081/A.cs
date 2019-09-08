using System;
using System.Linq;

namespace ABC081
{
    class A
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.Where(x => x == '1').Count());
        }
    }
}
