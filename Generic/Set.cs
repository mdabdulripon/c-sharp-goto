using System;
using System.Collections.Generic;

namespace Set
{
    public class Program
    {
        static void Main(string[] args)
        {
            // HashSet || Set with int type
            var numbers = new HashSet<int>();
            numbers.Add(1);
            numbers.Add(2); // this ignore because its a same value.
            numbers.Add(3);
            numbers.Add(2);

            foreach (var number in numbers)
            {
                Console.WriteLine($"numbers : {number}"); // return 1, 2, 3
            }
            Console.WriteLine(numbers.Count); // return 3


            // HashSet || Set with string type
            var names = new HashSet<string>();
            names.Add("Ripon");
            names.Add("Mun");
            names.Add("Ripon"); // this ignore because its a same value.
            names.Add("Labib");

            foreach (var name in names)
            {
                Console.WriteLine($"names : {name}"); // return Ripon, Mun, Labib
            }
            Console.WriteLine(names.Count); // return 3



            // HashSet || Set with Employee type
            var employees = new HashSet<Employee>();
            employees.Add(new Employee { name = "Shama" });
            employees.Add(new Employee { name = "Mummun" });
            employees.Add(new Employee { name = "Shama" }); // It has no idea that this employee is same object
            employees.Add(new Employee { name = "Sadia" });

            foreach (var employee in employees)
            {
                Console.WriteLine($"names : {employee.name}"); // return Shama, Mummun, Shama, Sadia
            }
            Console.WriteLine(employees.Count); // return 4

        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string name { get; set; }
    }
}
