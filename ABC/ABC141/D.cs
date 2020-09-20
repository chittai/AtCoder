using System;
using System.Collections.Generic;

namespace ABC141
{
    class D
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            double[] A = new double[N];

            PriorityQueue<double> pq = new PriorityQueue<double>();
            for (int i = 0; i < N; i++)
            {
                pq.Enqueue(double.Parse(input[i]));
            }

            double now = 0;
            for (int i = 0; i < M; i++)
            {
                now = Math.Floor(pq.Top * (0.5));
                pq.Dequeue();
                pq.Enqueue(now);
            }

            double sum = 0;
            while (0 < pq.Count)
            {
                sum += pq.Top;
                pq.Dequeue();
            }
            Console.WriteLine(sum);
        }
    }

    class PriorityQueue<T> where T : IComparable<T>
    {
        List<T> buffer;

        public PriorityQueue() { this.buffer = new List<T>(); }
        public PriorityQueue(int capacity) { this.buffer = new List<T>(capacity); }

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

        public void Enqueue(T elem)
        {
            PushHeap(this.buffer, elem);
        }

        public void Dequeue()
        {
            PopHeap(this.buffer);
        }

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
