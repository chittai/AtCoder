using System;

namespace ABC138
{
    class A
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            if (3200 <= a)
            {
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("red");
            }
        }
    }
}
