using System;
using System.Collections.Generic;

namespace GradeBook {

    class Program {
        static void Main (string[] args) {
            var book = new Book ();
            List<double> grades = new List<double> () { 1.3, 44.3, 19, 22 };
            grades.Add (1.3);
            var result = 0.0;
            foreach (double number in grades) {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine ($"The average is {result:N1}");
            if (args.Length > 0) {
                //Console.WriteLine("Hello " + args[0] + "!");
                Console.WriteLine ($"Hello {args[0]}!");
            } else {
                Console.WriteLine ("Hello!");
            }
        }
    }
}