using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries) 
        { 
            Countries = countries;
        }

        public List<Country> Countries = new List<Country>(); 

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++) 
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}
