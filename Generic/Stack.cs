using System;
using System.Collections.Generic;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Stack => First in Last out. For example: The stack of book. 
            // If you want to take out a book the last one get out first.
            var employees = new Stack<Employee>();
            employees.Push(new Employee { name = "Ripon" });
            employees.Push(new Employee { name = "Shama" });
            employees.Push(new Employee { name = "Mun" });
            employees.Push(new Employee { name = "Sadia" });

            Console.WriteLine("------------------------- Reading each stack members -------------------------");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.name); // Ripon, Shama, Mun, Sadia
            }

            Console.WriteLine("------------------------- Grt the first stack and length -------------------------");
            Console.WriteLine(employees.Count); // 4
            var pickOne = employees.Peek();
            Console.WriteLine(pickOne.name); // Ripon

            Console.WriteLine("------------------------- Removing each stack members -------------------------");
            while (employees.Count > 0)
            {
                var emp = employees.Pop();
                Console.WriteLine(emp.name); // Ripon, Shama, Mun, Sadia
            }
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string name { get; set; }
    }
}
