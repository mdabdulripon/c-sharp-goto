using System;
using System.Collections.Generic;
using System.Text;

namespace FileReader
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Continent { get; set; }
        public int Polulation { get; set; }

        public Country(string name, string code, string continent, int population)
        {
            Name = name;
            Code = code;
            Continent = continent;
            Polulation = population;
        }
    }
}
