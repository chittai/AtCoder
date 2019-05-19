using System;
using System.Linq;

namespace ABC126
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            //int n = int.Parse(s2);

            string s2 = "";
            int n1 = 0;
            for (int i = 0; i < 2; i++)
            {
                s2 += s1[i];
            }
            n1 = int.Parse(s2);

            string s3 = "";
            int n2 = 0;
            for (int i = 2; i < 4; i++)
            {
                s3 += s1[i];
            }
            n2 = int.Parse(s3);

            int flagA = 0;
            int flagB = 0;
            if (1 <= n1 && n1 <= 12)
                flagA = 0;
            else
                flagA = 1;

            if (1 <= n2 && n2 <= 12)
                flagB = 0;
            else
                flagB = 1;


            if (flagA == 0 && flagB == 0)
                Console.WriteLine("AMBIGUOUS");
            else if (flagA == 0 && flagB == 1)
                Console.WriteLine("MMYY");
            else if (flagA == 1 && flagB == 0)
                Console.WriteLine("YYMM");
            else if (flagA == 1 && flagB == 1)
                Console.WriteLine("NA");
        }
    }
}
