using System.Collections.Generic;
namespace GradeBook {
        class Book {
                private List<double> grades;
                public Book () {
                        grades = new List<double> ();
                }
                public void AddGrade (double grade) {
                        grades.Add (grade);
                }
        }
}