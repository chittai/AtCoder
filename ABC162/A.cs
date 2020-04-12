using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC162
{
    class A
    {
        static void Main(string[] args)
        {
            var N = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (N[i] == '7') { Console.WriteLine("Yes"); return; }
            }
            Console.WriteLine("No");
        }
    }
}

