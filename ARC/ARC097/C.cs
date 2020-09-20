using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC097
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            string s = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < s.Length - i + 1; j++)
                {
                    string tmp = s.Substring(j, i);
                    list.Add(tmp);
                }

                list = list.Distinct().OrderBy(x => x).ToList();
            }
            //Console.WriteLine(string.Join(",", list));
            Console.WriteLine(list[K - 1]);
        }
    }
}
