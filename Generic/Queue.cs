using System;
using System.Collections.Generic;

namespace Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Queue => First in first out. For example people are standing in a line.
            // The first person in the line get the serve first and get out first.
            var line = new Queue<Employee>();
            line.Enqueue(new Employee { name = "Ripon"});
            line.Enqueue(new Employee { name = "Shama" });
            line.Enqueue(new Employee { name = "Mun" });
            line.Enqueue(new Employee { name = "Sadia" });

            Console.WriteLine("------------------------- Reading each queue members -------------------------");
            foreach (var emp in line)
            {
                Console.WriteLine(emp.name); // Ripon, Shama, Mun, Sadia
            }

            Console.WriteLine("------------------------- Grt the first queue and length -------------------------");
            Console.WriteLine(line.Count); // 4
            var pickOne = line.Peek();
            Console.WriteLine(pickOne.name); // Ripon

            Console.WriteLine("------------------------- Removing each queue members -------------------------");
            while (line.Count > 0)
            {
                var emp = line.Dequeue();
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
