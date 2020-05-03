using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FileReader
{
    public class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string filePath)
        {
            _csvFilePath = filePath;
        }

        public List<Country> ReadAllCountries()
        {

            var countries = new List<Country>();
            using (var sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(line));
                }
            }
            return countries;
        }

        private Country ReadCountryFromCsvLine(string line)
        {
            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            string[] lineItems = CSVParser.Split(line);

            int populationValue;

            string name = lineItems[0].Trim();
            string code = lineItems[1].Trim();
            string continent = lineItems[2].Trim();
            int polulation = int.TryParse(lineItems[3], out populationValue) ? populationValue : 0;

            return new Country(name, code, continent, polulation);
        }
    }
}
