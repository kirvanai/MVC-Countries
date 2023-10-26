namespace MVC_Countries
{
    public class Program
    {
        static void Main(string[] args)
        {
            CountryController controller = new CountryController();
            controller.WelcomeAction();
        }
    }
}