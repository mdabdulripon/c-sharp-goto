using System;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array 
            var employees = new Employee[3] {
                new Employee { name = "ripon" },
                new Employee { name = "wen" },
                new Employee { name = "ripon" },
            };

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
