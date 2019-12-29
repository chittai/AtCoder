using System;
using System.Linq;

namespace ABC149
{
    class C
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            bool isOK = false;

            while (!isOK)
            {
                if (IsPrimeNumber(X)) { Console.WriteLine(X); return; }
                X++;
            }
        }

        static bool IsPrimeNumber(int number)
        {
            double i = number;
            // 平方根を求める
            double x = Math.Sqrt(i);
            // 平方根以下の値で割り切れるのか確認する
            // 最小値は2
            for (double j = 2; j <= x; j++)
            {
                if ((number % j) == 0) { return false; }
            }
            if (number == 1) { return false; }
            return true;
        }
    }
}
