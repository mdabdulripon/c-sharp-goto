using System;
using System.ComponentModel.Design;

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

            // Create an instance of the generic methods
            var repo = new VendorRepository();
            var sql = "Select * From SomeTable";
            var getIntgerValue = repo.RetriveValue<int>(sql, 32);
            Console.WriteLine(getIntgerValue);

            var getStringValue = repo.RetriveValue<string>(sql, "Value");
            Console.WriteLine(getStringValue);
        }
    }
}
