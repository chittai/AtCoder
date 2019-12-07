using System;

namespace CF2017F
{
    class B
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int[] alphaCount = new int[3];
            for (int i = 0; i < s.Length; i++)
            {
                alphaCount[s[i] - 'a']++;
            }

            while (0 < alphaCount[0] && 0 < alphaCount[1] && 0 < alphaCount[2])
            {
                alphaCount[0]--;
                alphaCount[1]--;
                alphaCount[2]--;
            }

            for (int i = 0; i < alphaCount.Length; i++)
            {
                if (1 < alphaCount[i]) { Console.WriteLine("NO"); return; }
            }

            Console.WriteLine("YES");
        }
    }
}
