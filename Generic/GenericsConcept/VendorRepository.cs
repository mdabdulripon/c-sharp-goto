using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsConcept
{
    public class VendorRepository
    {

        public int CalculateAge(int birthYear)
        {
            var age = DateTime.Today.Year - birthYear;
            return age;
        }

        // Generics Methods
        public T RetriveValue<T>(string sql, T value)
        {
            return value;
        }
    }
}
