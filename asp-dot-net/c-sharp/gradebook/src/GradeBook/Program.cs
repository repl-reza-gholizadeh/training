using System;
using System.Collections.Generic;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            var numbers = new double[] { 1.3, 44.3, 19 };
            List<double> grades = new List<double> () { 1.3, 44.3, 19, 22 };
            grades.Add (1.3);
            var result = 0.0;
            foreach (double number in grades) {
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