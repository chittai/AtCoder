using System;
using System.Collections.Generic;

namespace ABC007
{
    class B
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();

            if (A.Length == 1)
            {
                if (A[0] - 'a' == 0) { Console.WriteLine(-1); return; }
                else { Console.WriteLine((char)(A[0] - 1)); return; }
            }
            Console.WriteLine(A.Substring(0, A.Length - 1));
        }
    }
}
