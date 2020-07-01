using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple type array like string 
            string[] colorStr = new string[5] { "Black", "White", "Yellow", "Red", "Blue" };

            //Create Simple integer type array
            var grade = new int[7] { 98, 99, 67, 83, 55, 66, 90 };

            // Complex Array like object.
            var employees = new Employee[3] {
                new Employee { Id= 1, name = "ripon", age = 30 },
                new Employee { Id= 2, name = "labib", age = 1 },
                new Employee { Id = 3, name = "arish", age = 1 },
            };

            // Looping employee 
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.name);
            }
            // Methods : Static methods:
            var yellowIndex = Array.IndexOf(grade, 90);

            // Methods : Change Red to Black:
            colorStr.SetValue("Balck", 3);

            // Check index of complex array like: Objects
            var index = Array.FindIndex(employees, emp => emp.name == "arish");
        }
    }
}
