using System;
using System.Linq;

namespace ABC027
{
    class A
    {
        static void Main(string[] args)
        {
            int[] l = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int ans = 0;
            if (l[0] == l[1]) ans = l[2];
            if (l[1] == l[2]) ans = l[0];
            if (l[0] == l[2]) ans = l[1];

            Console.WriteLine(ans);
        }
    }
}
