using System;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            double[] numbers = new double[3];
            var someArray = new double[2] { 22, 1.2 };
            numbers[0] = 1.2;
            numbers[1] = 2.2;
            numbers[2] = 3.3;
            var result = numbers[0];
            result += numbers[1];
            result += numbers[2];
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