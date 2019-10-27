using System;

namespace CF2016qB
{
    class A
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string k = "CODEFESTIVAL2016";
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != k[i]) count++;
            }
            Console.WriteLine(count);
        }
    }
}
