using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        List<Country> CountryDB = new List<Country>();

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public CountryController()
        {
            List<string> franceColors = new List<string> { "red", "white", "blue" };
            Country france = new Country("France", Continent.Europe, franceColors);
            CountryDB.Add(france);
            List<string> brazilColors = new List<string> { "blue", "yellow", "blue" };
            Country brazil = new Country("Brazil", Continent.SouthAmerica, brazilColors);
            CountryDB.Add(brazil);
            List<string> usaColors = new List<string> { "red", "white", "blue" };
            Country USA = new Country("United States of America", Continent.NorthAmerica, usaColors);
            CountryDB.Add(USA);
            List<string> japanColors = new List<string> { "red", "white"};
            Country japan = new Country("Japan", Continent.Asia, japanColors);
            CountryDB.Add(japan);
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            clv.Display();
            int choice = int.Parse(Console.ReadLine());
            string yorNo = "";
            bool goOn = true;
            while (goOn == true)
            {
                
                CountryAction(CountryDB[choice]);
                Console.WriteLine("Would you like to learn about another country? y/n");
                yorNo = Console.ReadLine();
                if (yorNo == "y")
                {
                    clv.Display();
                    choice = int.Parse(Console.ReadLine());
                    goOn = true;
                }
                else
                {
                    goOn = false;
                }
            }
        }
    }
}
