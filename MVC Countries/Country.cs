using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public enum Continent
    {
        Africa,
        Antarctica,
        Asia,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica,
    }
    public class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get;} = new List<string>();

        public Country() { }
        public Country(string name, Continent continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }

}
