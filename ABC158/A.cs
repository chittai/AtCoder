using System;
using System.Linq;

namespace ABC158
{
    class A
    {
        static void Main(string[] args)
        {
            //var a = Console.ReadLine().Split().Select().ToArray();
            var s = Console.ReadLine();

            int a = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                if (s[i] == 'B') b = 1;
                if (s[i] == 'A') a = 1;
            }

            if (a == 0 || b == 0) Console.WriteLine("No");
            else Console.WriteLine("Yes");
        }
    }
}
