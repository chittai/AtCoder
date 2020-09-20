using System;

namespace ABC053
{
    class B2
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.LastIndexOf('Z') - s.IndexOf('A') + 1);
        }
    }
}
