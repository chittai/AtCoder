using System;
using System.Linq;

namespace MSBPC2019
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            for (double i = 0; i <= N; i++)
            {
                //Console.WriteLine((long)(i * 1.08));
                if (N == (long)(i * 1.08)) { Console.WriteLine(i); return; }
            }
            Console.WriteLine(":(");
        }
    }
}
