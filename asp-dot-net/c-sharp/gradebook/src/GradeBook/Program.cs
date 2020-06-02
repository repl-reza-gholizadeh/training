using System;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            var numbers = new double[3] { 1.3, 44.3, 19 };
            var result = 0.0;
            foreach (double number in numbers) {
                result += number;
            }
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