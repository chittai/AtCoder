using System;

namespace ABC071
{
    class B
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();

            for (var i = 'a'; i <= 'z'; i++)
            {
                if (!S.Contains(i.ToString())) { Console.WriteLine(i); return; }
            }
            Console.WriteLine("None");
        }
    }
}
