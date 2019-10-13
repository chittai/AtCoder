using System;
using System.Linq;

namespace Collections
{
    class UF
    {
        int[] parent;
        public UF(int N) { parent = Enumerable.Range(0, N).ToArray(); }

        int root(int x)
        {
            if (parent[x] == x) return x;
            return parent[x] = root(parent[x]);
        }

        public void Unite(int x, int y)
        {
            int rx = root(x);
            int ry = root(y);
            if (rx == ry) return;
            parent[rx] = ry;
        }
        public bool CheckSame(int x, int y)
        {
            int rx = root(x);
            int ry = root(y);
            return rx == ry;
        }
    }
}