using System;

namespace ABC114
{
    class B
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int res = int.MaxValue;
            for (int i = 0; i < S.Length - 2; i++)
            {
                string X = S.Substring(i, 3);
                res = Math.Min(res, Math.Abs(int.Parse("753") - int.Parse(X)));
            }
            Console.WriteLine(res);
        }
    }
}
