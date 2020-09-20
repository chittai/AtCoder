using System;
using System.Linq;

namespace ABC045
{
    class B
    {
        static void Main(string[] args)
        {

            var sa = Console.ReadLine().ToList();
            var sb = Console.ReadLine().ToList();
            var sc = Console.ReadLine().ToList();

            char c = sa[0];
            sa.RemoveAt(0);
            //Console.WriteLine(string.Join(',', sa));
            for (int i = 0; 0 <= sa.Count && 0 <= sb.Count && 0 <= sc.Count; i++)
            {
                if (c == 'a' && sa.Count == 0) { Console.WriteLine('A'); return; }
                if (c == 'b' && sb.Count == 0) { Console.WriteLine('B'); return; }
                if (c == 'c' && sc.Count == 0) { Console.WriteLine('C'); return; }

                if (0 < sa.Count && c == 'a') { c = sa[0]; sa.RemoveAt(0); }
                if (0 < sb.Count && c == 'b') { c = sb[0]; sb.RemoveAt(0); }
                if (0 < sc.Count && c == 'c') { c = sc[0]; sc.RemoveAt(0); }
            }
        }
    }
}
