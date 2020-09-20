using System;
using System.Linq;
namespace ABC082
{
    class B
    {
        static void Main(string[] args)
        {
            string s = new string(Console.ReadLine().OrderBy(x => x).ToArray());
            string t = new string(Console.ReadLine().OrderByDescending(x => x).ToArray());

            Console.WriteLine(s.CompareTo(t) == -1 ? "Yes" : "No");
        }
    }
}
