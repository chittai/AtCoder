using System;
using System.Linq;

namespace ABC072
{
    class B
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string(Console.ReadLine().Where((x, index) => index % 2 == 0).ToArray()));
        }
    }
}
