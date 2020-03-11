using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KPC2019
{
    class B2
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();

            // keymoonさんの回答と同じ書き方を試す
            // https://atcoder.jp/contests/keyence2019/submissions/10724495

            Console.WriteLine(
                Regex.IsMatch(S, "^.*keyence$") ||
                Regex.IsMatch(S, "^k.*eyence$") ||
                Regex.IsMatch(S, "^ke.*yence$") ||
                Regex.IsMatch(S, "^key.*ence$") ||
                Regex.IsMatch(S, "^keye.*nce$") ||
                Regex.IsMatch(S, "^keyen.*ce$") ||
                Regex.IsMatch(S, "^keyenc.*e$") ||
                Regex.IsMatch(S, "^keyence.*$") ? "YES" : "NO");
        }
    }
}
