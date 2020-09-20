using System;
 
namespace ABC124.A
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int b = int.Parse(input[0]);
            int c = int.Parse(input[1]);
 
            int maxValue = 0;
 
            for (int i = 0; i < 2; i++){
                if (b >= c)
                {
                    maxValue += b;
                    b--;
                }
                else
                {
                    maxValue += c;
                    c--;
                }
            }
 
            Console.WriteLine(maxValue);
        }
    }
}