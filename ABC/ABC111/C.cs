using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ABC111
{
    class C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //StreamReader sr = new StreamReader(@"./testcase/testcase");
            //int n = int.Parse(sr.ReadLine());
            //int[] v = sr.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dictOdd = new Dictionary<int, int>();
            Dictionary<int, int> dictEven = new Dictionary<int, int>();

            // Odd
            int oddMaxKey = 0;
            int oddMaxValue = 0;
            for (int i = 0; i < n; i += 2)
            {
                if (!dictOdd.ContainsKey(v[i])) dictOdd.Add(v[i], 1);
                else dictOdd[v[i]]++;
                if (oddMaxValue < dictOdd[v[i]]) { oddMaxKey = v[i]; oddMaxValue = dictOdd[v[i]]; }
            }

            // Even
            int evenMaxKey = 0;
            int evenMaxValue = 0;
            for (int i = 1; i < n; i += 2)
            {
                if (!dictEven.ContainsKey(v[i])) dictEven.Add(v[i], 1);
                else dictEven[v[i]]++;
                if (evenMaxValue < dictEven[v[i]]) { evenMaxKey = v[i]; evenMaxValue = dictEven[v[i]]; }
            }

            int oddSum = 0;
            int oddIndex = 0;
            int oddSecondMaxKey = 0;
            foreach (var i in dictOdd.OrderBy(x => x.Value))
            {
                oddSum += i.Value;
                if (oddIndex == dictOdd.Count - 1) { oddSecondMaxKey = i.Key; }
                oddIndex++;
            }

            //Console.WriteLine(oddSum);

            int evenSum = 0;
            int evenIndex = 0;
            int evenSecondMaxKey = 0;
            foreach (var i in dictEven.OrderBy(x => x.Value))
            {
                evenSum += i.Value;
                if (evenIndex == dictEven.Count - 1) { evenSecondMaxKey = i.Key; }
                evenIndex++;
            }

            if (evenMaxKey == oddMaxKey)
            {
                if (evenMaxValue < oddMaxValue)
                {
                    Console.WriteLine(oddSum - dictOdd[oddMaxKey] + evenSum - dictEven[evenSecondMaxKey]);
                }
                else
                {
                    Console.WriteLine(oddSum - dictOdd[oddSecondMaxKey] + evenSum - dictEven[evenMaxKey]);
                }
            }
            else
            {
                Console.WriteLine(oddSum - dictOdd[oddMaxKey] + evenSum - dictEven[evenMaxKey]);
            }
        }
    }
}