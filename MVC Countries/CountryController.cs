using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    public class CountryController
    {
        List<Country> CountryDB = new List<Country>() 
        { 
            new Country("France", Continent.Europe, "Red", "White", "Blue"),
            new Country("Brazil", Continent.SouthAmerica, "Blue", "Yellow", "Green"),
            new Country("United States of America", Continent.NorthAmerica, "Red", "White", "Blue"),
            new Country("Japan", Continent.Asia, "Red", "White") 
        };
        

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
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
