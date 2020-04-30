using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List
            var grades = new List<double>() { 12.32, 32.33, 17.77, 9.99 };
            grades.Add(10.11);

            double result = 0;
            foreach (var num in grades)
            {
                result += num;
            }
            Console.WriteLine($"The sum of the List is: {result}");

            var avarage = result / grades.Count;
            // :N2 is a formater which take 2 decimal point number
            Console.WriteLine($"The avarage of the List is: {avarage:N2}");
        }
    }
}
