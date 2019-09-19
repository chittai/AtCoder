using System;

namespace ABC088
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            if (0 <= A - (N % 500)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
