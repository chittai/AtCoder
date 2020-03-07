using System;
namespace ABC107
{
    class A
    {
        static void Main(string[] args)
        {
            long K = long.Parse(Console.ReadLine());
            Console.WriteLine(K % 2 == 0 ? K / 2 * K / 2 : (K / 2 + 1) * (K / 2));
        }
    }
}
