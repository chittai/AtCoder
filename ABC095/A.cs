using System;
using System.Linq;

namespace ABC095
{
    class A
    {
        static void Main(string[] args)
        {
            int count = Console.ReadLine().Count(x => x == 'o');
            Console.WriteLine(700 + count * 100);
        }
    }
}
