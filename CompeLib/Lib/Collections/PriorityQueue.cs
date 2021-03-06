using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        List<T> buffer;

        public PriorityQueue() { this.buffer = new List<T>(); }
        public PriorityQueue(int capacity) { this.buffer = new List<T>(capacity); }


        /// <summary>
        /// ヒープ化されている配列リストに新しい要素を追加する。
        /// </summary>
        /// <param name="array">対象の配列リスト</param>
        static void PushHeap(List<T> array, T elem)
        {
            int n = array.Count;
            array.Add(elem);

            while (n != 0)
            {
                int i = (n - 1) / 2;
                if (array[n].CompareTo(array[i]) > 0)
                {
                    T tmp = array[n]; array[n] = array[i]; array[i] = tmp;
                }
                n = i;
            }
        }

        /// <summary>
        /// ヒープから最大値を削除する。
        /// </summary>
        /// <param name="array">対象の配列リスト</param>
        static void PopHeap(List<T> array)
        {
            int n = array.Count - 1;
            array[0] = array[n];
            array.RemoveAt(array.Count - 1);

            for (int i = 0, j; (j = 2 * i + 1) < n;)
            {
                if ((j != n - 1) && (array[j].CompareTo(array[j + 1]) < 0))
                    j++;
                if (array[i].CompareTo(array[j]) < 0)
                {
                    T tmp = array[j]; array[j] = array[i]; array[i] = tmp;
                }
                i = j;
            }
        }

        /// <summary>
        /// 要素のプッシュ。
        /// </summary>
        /// <param name="elem">挿入したい要素</param>
        public void Enqueue(T elem)
        {
            PushHeap(this.buffer, elem);
        }

        /// <summary>
        /// 要素を1つポップ。
        /// </summary>
        /// <remarks>
        /// 今回の実装では、先頭要素の読み出しと削除は別に行う。
        /// この Pop では削除のみ。
        /// 読み出しには Top プロパティを使う。
        /// </remarks>
        public void Dequeue()
        {
            PopHeap(this.buffer);
        }

        /// <summary>
        /// 先頭要素の読み出し。
        /// </summary>
        public T Top
        {
            get { return this.buffer[0]; }
        }

        public int Count
        {
            get { return this.buffer.Count; }
        }
    }
}