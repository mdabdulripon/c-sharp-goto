using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[4] { 12.32, 32.33, 17.77, 9.99 };

            double result = 0;
            foreach (var num in numbers)
            {
                result += num;
            }
            Console.WriteLine($"The sum of array is: {result}");

            Console.WriteLine($"The avarage of the array is: {result / numbers.Length }");
        }
    }
}
