using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{

    class DFS
    {
        static int N = 10;
        static List<int>[] list = new List<int>[N];

        public static void dfs()
        {

            // init
            for (int i = 0; i < N; i++)
            {
                list[i] = new List<int>();
            }

            int[] input;
            int x = 0;
            int y = 0;
            for (int i = 0; i < N; i++)
            {
                // ex: (1,2) など、辺の情報をinputとして受ける想定。
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                // 木構造の辺情報がinputにあるときは、相互に追加する
                x = input[0] - 1;
                y = input[1] - 1;
                list[x].Add(y);
                list[y].Add(x);
            }
        }

        public void ExecDfs(int now, int previous)
        {
            // 終了条件
            //if(xx) return;

            foreach (var item in list[now])
            {
                if (item != previous) ExecDfs(item, now);
            }
        }

    }

    class BFS
    {
        public static void bfs()
        {
            int N = 10;
            List<int>[] list = new List<int>[N];

            // init
            for (int i = 0; i < N; i++)
            {
                list[i] = new List<int>();
            }

            int[] input;
            int x = 0;
            int y = 0;
            for (int i = 0; i < N; i++)
            {
                // ex: (1,2) など、辺の情報をinputとして受ける想定。
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                // 木構造の辺情報がinputにあるときは、相互に追加する
                x = input[0] - 1;
                y = input[1] - 1;
                list[x].Add(y);
                list[y].Add(x);
            }

            // すでに処理されたノードかどうか判定するための配列
            bool[] Used = new bool[N];

            Queue<int> q = new Queue<int>();
            for (int i = 0; i < N; i++)
            {
                if (Used[i]) continue;
                Used[i] = true;
                q.Enqueue(i);

                while (q.Any())
                {
                    foreach (var item in list[q.Dequeue()])
                    {
                        if (Used[item]) continue;
                        Used[item] = true;
                        q.Enqueue(item);
                    }
                }
            }
        }
    }
}