using System;
using System.Linq;
using System.Collections.Generic;

namespace PAST001
{
    class G
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            List<string> slist = new List<string>();
            for (int i = 0; i < S.Length;)
            {
                string s = "";
                int count = 0;

                int count2 = 0;
                int index = i;

                while (count < 2)
                {
                    if ('A' <= S[i] && S[i] <= 'Z')
                    {
                        count++;
                    }
                    count2++;
                    i++;
                }
                s = S.Substring(index, count2);
                slist.Add(s);
            }
            slist.Sort();
            Console.WriteLine(string.Join("", slist));
        }
    }


}
