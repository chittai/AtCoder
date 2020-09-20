using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC113
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input[0];
            int M = input[1];

            string[] py;
            List<Tuple<int, int, int>> tupleList = new List<Tuple<int, int, int>>();
            for (int i = 0; i < M; i++)
            {
                py = Console.ReadLine().Split();
                tupleList.Add(Tuple.Create(i, int.Parse(py[0]), int.Parse(py[1])));
            }
            var newList = tupleList.OrderBy(x => x.Item2).ThenBy(x => x.Item3);

            string[] Res = new string[M];
            int prefecture = newList.First().Item2;
            int index = 1;
            foreach (var i in newList)
            {
                if (i.Item2 != prefecture) { index = 1; prefecture = i.Item2; }
                Res[i.Item1] = i.Item2.ToString().PadLeft(6, '0') + index.ToString().PadLeft(6, '0');
                index++;
            }

            foreach (var i in Res)
            {
                Console.WriteLine(i);
            }
        }
    }
}