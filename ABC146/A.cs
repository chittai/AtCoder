using System;
using System.Linq;

namespace ABC146
{
    class A
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            if (S == "SUN") Console.WriteLine(7);
            if (S == "MON") Console.WriteLine(6);
            if (S == "TUE") Console.WriteLine(5);
            if (S == "WED") Console.WriteLine(4);
            if (S == "THU") Console.WriteLine(3);
            if (S == "FRI") Console.WriteLine(2);
            if (S == "SAT") Console.WriteLine(1);
        }
    }
}