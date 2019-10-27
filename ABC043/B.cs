using System;
using System.Collections.Generic;

namespace ABC043
{
    class B
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            List<char> l = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0') l.Add('0');
                if (s[i] == '1') l.Add('1');
                if (s[i] == 'B' && 0 < l.Count) l.RemoveAt(l.Count - 1);
            }
            Console.WriteLine(string.Join("", l));
        }
    }
}
