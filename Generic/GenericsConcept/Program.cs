using System;

namespace GenericsConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new OperationResult<bool>(true, "boolean value has passed.");

            var y = new OperationResult<decimal>(5.5M, "Decimal value has passed.");

            Console.WriteLine(x.Result);
            Console.WriteLine(x.Message);
        }
    }
}
