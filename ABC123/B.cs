using System;

namespace ABC123
{
    class B
    {
        static void Main(string[] args)
        {
            int res = 0;
            int max = 10;
            int ll = 0;
            int l = 0;

            for (int i = 0; i < 5; i++)
            {
                ll = int.Parse(Console.ReadLine());
                l = ll % 10;
                if (0 < l)
                {
                    max = Math.Min(max, l);
                    res += ll + (10 - l);
                }
                else
                {
                    res += ll;
                }
            }
            Console.WriteLine(res - (10 - max));
        }
    }
}
