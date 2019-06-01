using System;

namespace MSPC
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = int.Parse(s);

            Console.WriteLine(180 * (N - 2));
        }
    }
}
