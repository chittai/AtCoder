using System;

namespace ABC079
{
    class C
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int A = (char)input[0] - '0';
            int B = (char)input[1] - '0';
            int C = (char)input[2] - '0';
            int D = (char)input[3] - '0';

            if (A + B + C + D == 7) { Console.WriteLine(A.ToString() + "+" + B.ToString() + "+" + C.ToString() + "+" + D.ToString() + "=7"); }
            else if (A + B + C - D == 7) { Console.WriteLine(A.ToString() + "+" + B.ToString() + "+" + C.ToString() + "-" + D.ToString() + "=7"); }
            else if (A + B - C - D == 7) { Console.WriteLine(A.ToString() + "+" + B.ToString() + "-" + C.ToString() + "-" + D.ToString() + "=7"); }
            else if (A + B - C + D == 7) { Console.WriteLine(A.ToString() + "+" + B.ToString() + "-" + C.ToString() + "+" + D.ToString() + "=7"); }
            else if (A - B + C + D == 7) { Console.WriteLine(A.ToString() + "-" + B.ToString() + "+" + C.ToString() + "+" + D.ToString() + "=7"); }
            else if (A - B + C - D == 7) { Console.WriteLine(A.ToString() + "-" + B.ToString() + "+" + C.ToString() + "-" + D.ToString() + "=7"); }
            else if (A - B - C - D == 7) { Console.WriteLine(A.ToString() + "-" + B.ToString() + "-" + C.ToString() + "-" + D.ToString() + "=7"); }
            else if (A - B - C + D == 7) { Console.WriteLine(A.ToString() + "-" + B.ToString() + "-" + C.ToString() + "+" + D.ToString() + "=7"); }
        }
    }
}
