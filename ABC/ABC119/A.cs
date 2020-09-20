using System;

namespace ABC119
{
    class A
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (0 < s.CompareTo("2019/04/30")) Console.WriteLine("TBD");
            else Console.WriteLine("Heisei");
        }
    }
}
