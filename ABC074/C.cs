using System;

namespace ABC074
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int D = int.Parse(input[3]);
            int E = int.Parse(input[4]);
            int F = int.Parse(input[5]);

            int waterSum = 0;
            int waterSumRes = 0;
            int sugarSum = 0;
            double maxDens = 0;
            double dens = 0;
            for (int i = 0; i * A * 100 <= F; i++)
            {
                for (int j = 0; (i * A * 100) + (j * B * 100) <= F; j++)
                {
                    if (i == 0 && j == 0) continue;
                    waterSum = (i * A * 100) + (j * B * 100);

                    for (int k = 0; (waterSum + (k * C) <= F); k++)
                    {
                        for (int l = 0; (waterSum + (k * C) + (l * D)) <= F; l++)
                        {
                            dens = (double)((k * C) + (l * D)) / waterSum;
                            //Console.WriteLine("dens : " + dens);
                            //Console.WriteLine("maxdens : " + maxDens);

                            if (dens < maxDens || E / 100d < dens) continue;
                            sugarSum = (k * C) + (l * D);
                            //Console.WriteLine("sugarSum : " + sugarSum);
                            waterSumRes = waterSum;
                            maxDens = dens;
                        }
                    }
                }
            }
            Console.WriteLine($"{waterSumRes + sugarSum} {sugarSum}");
        }
    }
}
