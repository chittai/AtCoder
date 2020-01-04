using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{

    class BinarySearch
    {
        public static int LowerBound<T>(T[] a, T v)
        {
            return LowerBound(a, v, Comparer<T>.Default);
        }

        public static int LowerBound<T>(T[] a, T v, Comparer<T> cmp)
        {
            var l = 0;
            var r = a.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                var res = cmp.Compare(a[mid], v);
                if (res == -1) l = mid + 1;
                else r = mid - 1;
            }
            return l;
        }

        public static int UpperBound<T>(T[] a, T v)
        {
            return UpperBound(a, v, Comparer<T>.Default);
        }

        public static int UpperBound<T>(T[] a, T v, Comparer<T> cmp)
        {
            var l = 0;
            var r = a.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                var res = cmp.Compare(a[mid], v);
                if (res <= 0) l = mid + 1;
                else r = mid - 1;
            }
            return l;
        }
    }

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

        // 訪れたことがあるかどうかの処理をする
        // AtCoder Beginner Contest 075 C問題

        static void ExecVisitedDfs()
        {

            int N = 0;
            int M = 0;

            int[] a = new int[10];
            int[] b = new int[10];

            int res = 0;
            for (int i = 0; i < M; i++)
            {
                connect[a[i], b[i]] = false;
                connect[b[i], a[i]] = false;
                for (int j = 0; j < N; j++) visited[j] = false;

                VisitedDfs(0);

                bool bridge = false;
                for (int j = 0; j < N; j++)
                {
                    if (visited[j] == false) bridge = true;
                }
                if (bridge) res++;

                connect[a[i], b[i]] = true;
                connect[b[i], a[i]] = true;
            }
        }

        static bool[] visited;
        static bool[,] connect;
        static void VisitedDfs(int n)
        {
            visited[n] = true;
            for (int i = 0; i < N; i++)
            {
                if (connect[n, i] == false) continue;
                if (visited[i] == true) continue;
                VisitedDfs(i);
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