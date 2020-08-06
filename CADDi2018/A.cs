using System;
using System.Linq;

namespace CADDi2018
{
    class A
    {
        static void Main(string[] args)
        {
            //input
            var N = Console.ReadLine();
            Console.WriteLine(N.Count(x => x == '2'));
        }
    }
}
