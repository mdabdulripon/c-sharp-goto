using System;
using System.Collections.Generic;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\mdabd\OneDrive\Documents\projects\c-sharp-projects\projects\FileReader\csv\CountriesPopulation.csv";

            var reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            foreach (var country in countries)
            {
                var population = country.Polulation > 0 ? $"{country.Polulation}" : "Unknown";
                Console.WriteLine($"This is {country.Name} and the population is {population}");
            }
            Console.WriteLine($"{countries.Count} countries");

        }
    }
}
