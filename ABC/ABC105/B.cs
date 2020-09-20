using System;

namespace ABC105
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 4 == 0 || N % 7 == 0) { Console.WriteLine("Yes"); return; }

            while (6 < N)
            {
                N -= 4;
                if (N % 7 == 0) { Console.WriteLine("Yes"); return; }
            }
            Console.WriteLine("No");
        }
    }
}
