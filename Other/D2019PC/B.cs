using System;
using System.Linq;

namespace D2019PC
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = Console.ReadLine().Split(' ');
            int[] n = s.Select(x => int.Parse(x)).ToArray();

            int result = 0;
            int temp = n[3];
            int tempHJ = 0;

            for (int i = 0; i < (n[3] / n[0]) + 1; i++)
            {
                temp -= n[0] * i;
                tempHJ = temp;

                for (int j = 0; j < (temp / n[1]) + 1; j++)
                {
                    tempHJ -= n[1] * j;
                    if (tempHJ % n[2] == 0)
                    {
                        result++;
                    }

                    tempHJ = temp;
                }
                temp = n[3];
            }
            Console.WriteLine(result);
        }
    }
}
