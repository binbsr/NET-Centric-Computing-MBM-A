using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte>{ 2, 3 };
            ages.Add(1);
            ages.Add(10);
            ages.Add(100);
            ages.Add(65);
            ages.Add(254);
            ages.Add(96);
            ages.Add(69);

            List<Country> countries = new List<Country>();
            Country country1 = new Country();
            countries.Add(country1);
        }

        public void LearnDictionary()
        {
            var countryCapitals = new Dictionary<string, string>
            {
                ["Nepal"] = "Kathmandu",
                ["Aayam"] = "Neupane",
                ["Finland"] = "Switzerland"
            };

            foreach (var Country in countryCapitals)
            {
                Console.WriteLine($"Country : {Country.Key} Capital City: {Country.Value}");
            }
        }
    }

    public class Country
    {
        public string Name { get; set; }
    }
}