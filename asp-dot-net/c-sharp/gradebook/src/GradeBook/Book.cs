using System;
using System.Collections.Generic;
namespace GradeBook {
        class Book {
                public Book (string name) {
                        grades = new List<double> ();
                        this.name = name;
                }
                public void AddGrade (double grade) {
                        grades.Add (grade);
                }

                public void ShowStatistics () {
                        var result = 0.0;
                        var maxGrade = double.MinValue;
                        var minGrade = double.MaxValue;
                        foreach (double number in grades) {
                                maxGrade = Math.Max (number, maxGrade);
                                minGrade = Math.Min (number, minGrade);
                                result += number;
                        }
                        result /= grades.Count;
                        Console.WriteLine ($"The min grade is {minGrade}");
                        Console.WriteLine ($"The max grade is {maxGrade}");
                        Console.WriteLine ($"The average is {result:N1}");
                }

                private List<double> grades;
                private string name;
        }
}