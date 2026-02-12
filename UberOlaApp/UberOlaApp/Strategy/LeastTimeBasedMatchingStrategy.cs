using UberOlaApp.Managers;
using UberOlaApp.Models;

namespace UberOlaApp.Strategy
{
    class LeastTimeBasedMatchingStrategy: IDriverMatchingStrategy
    {
        public LeastTimeBasedMatchingStrategy() { }

        public Driver MatchDriver(TripMetaData tripMetaData) 
        {
            DriverManager driverManager = DriverManager.GetDriverManager();
            var driver = new Driver();

            if (driverManager.GetDrivesMap().Count == 0)
            {
                Console.WriteLine("No drivers! What service is this huh?");
            }
            else
            {
                Console.WriteLine("Using quadtree to see nearest cabs, using driver manager to get details of drivers and send notifications");

                driver = driverManager.GetDrivesMap().FirstOrDefault().Value;
                Console.WriteLine($"Setting {driver.Name} as driver");
                tripMetaData.SetDriverRating(driver.RATING);
            }            
            return driver;
        }
    }
}
