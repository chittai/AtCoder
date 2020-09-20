using System;

namespace ABC123 {
    class A {
        static void Main (string[] args) {
            int[] l = new int[5];
            for (int i = 0; i < 5; i++) {
                l[i] = int.Parse (Console.ReadLine ());
            }
            int k = int.Parse (Console.ReadLine ());
            bool isExist = false;
            if (k < (l[4] - l[0])) { isExist = true; }

            if (isExist) { Console.WriteLine (":("); } else { Console.WriteLine ("Yay!"); }
        }
    }
}
