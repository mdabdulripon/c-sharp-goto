using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.15);
            book.AddGrade(90.50);
            book.AddGrade(66.15);
            book.AddGrade(77.78);
            book.AddGrade(99.99);
            book.AddGrade(99.99);

            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The lowest grade is { stats.Low }");
            Console.WriteLine($"The highest grade is {stats.High }");
        }
    }
}
