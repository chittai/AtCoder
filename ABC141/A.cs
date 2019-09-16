using System;

namespace ABC141
{
    class A
    {
        static void Main(string[] args)
        {

            string S = Console.ReadLine();

            if (S[0] == 'S') { Console.WriteLine("Cloudy"); }
            if (S[0] == 'C') { Console.WriteLine("Rainy"); }
            if (S[0] == 'R') { Console.WriteLine("Sunny"); }

        }
    }
}
