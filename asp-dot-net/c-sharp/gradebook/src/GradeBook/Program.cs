using System;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            var x = 19.2;
            double y = 2.2;
            double result = x + y;
            Console.WriteLine (result);
            if (args.Length > 0) {
                //Console.WriteLine("Hello " + args[0] + "!");
                Console.WriteLine ($"Hello {args[0]}!");
            } else {
                Console.WriteLine ("Hello!");
            }
        }
    }
}