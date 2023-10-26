using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryView
    {
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public Country DisplayCountry {  get; set; }

        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine("Colors: ");
            foreach (string color in DisplayCountry.Colors) 
            { 
            Console.Write(color + ", ");
            }
            Console.WriteLine();
        }
    }
}
