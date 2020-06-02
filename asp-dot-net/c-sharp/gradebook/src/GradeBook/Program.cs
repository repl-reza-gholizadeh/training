using System;
using System.Collections.Generic;

namespace GradeBook {

    class Program {
        static void Main (string[] args) {
            var book = new Book ("someName");
            book.AddGrade (22.2);
            book.AddGrade (1.2);
            book.AddGrade (522.2);
            book.AddGrade (342.2);
            book.ShowStatistics ();
        }
    }
}