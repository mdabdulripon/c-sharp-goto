using System;
using System.Collections.Generic;

namespace Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Queue => First in first out. For example people are standing in a line.
            var line = new Queue<Employee>();
            line.Enqueue(new Employee { name = "Ripon"});
            line.Enqueue(new Employee { name = "Shama" });
            line.Enqueue(new Employee { name = "Mun" });
            line.Enqueue(new Employee { name = "Sadia" });

            foreach (var emp in line)
            {
                Console.WriteLine(emp.name); // Ripon, Shama, Mun, Sadia
            }
            
            Console.WriteLine("=================================");
            Console.WriteLine(line.Count);
            var pickOne = line.Peek();
            Console.WriteLine(pickOne.name);
            Console.WriteLine("=================================");



            while (line.Count > 0)
            {
                var emp = line.Dequeue();
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
