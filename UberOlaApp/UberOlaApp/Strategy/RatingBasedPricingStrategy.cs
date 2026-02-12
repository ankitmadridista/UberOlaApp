using UberOlaApp.Common;
using UberOlaApp.Models;

namespace UberOlaApp.Strategy
{
    class RatingBasedPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(TripMetaData tripMetaData)
        {
            double price = Util.IsHighRating(tripMetaData.RiderRating) ?
                55 : 65;
            Console.WriteLine("Based on " + 
                Util.RatingToString(tripMetaData.RiderRating) +
                " Rating price of the ride is " +
                price);
            return price;
        }
    }
}
