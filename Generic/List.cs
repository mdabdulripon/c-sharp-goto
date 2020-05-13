using System;
using System.Collections.Generic;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array 
            var employees = new List<Employee>  {
                new Employee { name = "ripon" },
                new Employee { name = "wen" },
                new Employee { name = "ripon" },
            };

            employees.Add(new Employee { name = "shama" });
            
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.name);
            }
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string name { get; set; }
    }
}
