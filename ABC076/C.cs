using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC076
{
    class C
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            bool isMatch = true;
            List<string> sList = new List<string>();

            var indexT = 0;
            var indexS = 0;
            for (int i = 0; i < s.Length - t.Length + 1; i++)
            {
                isMatch = true;
                indexS = i;
                indexT = 0;

                while (indexT < t.Length)
                {
                    if (s[indexS] != '?' && s[indexS] != t[indexT]) { isMatch = false; break; }
                    indexS++;
                    indexT++;
                }

                if (isMatch)
                {
                    string front = s.Substring(0, i);
                    string rear = s.Substring(i + t.Length, s.Length - front.Length - t.Length);

                    string res = front + t + rear;
                    res = res.Replace('?', 'a');
                    sList.Add(res);
                }
            }

            sList = sList.OrderBy(x => x).ToList();
            if (0 < sList.Count) Console.WriteLine(sList[0]);
            else Console.WriteLine("UNRESTORABLE");

        }
    }
}
