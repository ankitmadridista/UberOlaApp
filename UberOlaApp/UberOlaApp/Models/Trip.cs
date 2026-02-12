using UberOlaApp.Common.Enums;
using UberOlaApp.Strategy;

namespace UberOlaApp.Models
{
    public class Trip
    {
        public Rider? Rider { get; set; }
        public Driver? Driver { get; set; }

        public Location? srcLoc { get; set; }
        public Location? dstLoc { get; set; }

        public EnTripStatus TripStatus{ get; set; }

        public int TripId { get; set; }
        public double Price { get; set; }

        IPricingStrategy pricingStrategy { get; set; }

        IDriverMatchingStrategy driverMatchingStrategy { get; set; }

        public Trip(Rider rider, Driver driver, Location srcLoc, Location dstLoc, double price, IPricingStrategy pricingStrategy, IDriverMatchingStrategy driverMatchingStrategy)
        {
            this.Rider = rider;
            this.Driver = driver;
            this.srcLoc = srcLoc;
            this.dstLoc = dstLoc;
            this.pricingStrategy = pricingStrategy;
            this.driverMatchingStrategy = driverMatchingStrategy;
            this.TripStatus = EnTripStatus.DRIVER_ON_THE_WAY;
            this.Price = price;
            this.TripId = GenerateTripId();

        }

        public int GenerateTripId() {
            Random rnd = new Random();
            int num = rnd.Next();
            

            return num;
        }

        public int GetTripId()
        {
            return TripId;
        }

        public void displayTripDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"Trip id - {TripId}");
            Console.WriteLine($"Rider - {Rider.Name}");
            Console.WriteLine($"Driver - {Driver.Name}");
            Console.WriteLine($"Price - {Price}");
            Console.WriteLine($"Locations - {srcLoc.latitude}, {srcLoc.longitude}, {dstLoc.latitude}, {dstLoc.longitude}");
        }

        //public Trip displayTripDetailsData()
        //{


        //    Console.WriteLine();
        //    Console.WriteLine($"Trip id - {TripId}");
        //    Console.WriteLine($"Rider - {Rider.Name}");
        //    Console.WriteLine($"Driver - {Driver.Name}");
        //    Console.WriteLine($"Price - {Price}");
        //    Console.WriteLine($"Locations - {srcLoc.latitude}, {srcLoc.longitude}, {dstLoc.latitude}, {dstLoc.longitude}");
        //}
    }
}
