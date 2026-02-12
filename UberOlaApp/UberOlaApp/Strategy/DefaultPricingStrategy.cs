using UberOlaApp.Models;

namespace UberOlaApp.Strategy
{
    class DefaultPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(TripMetaData tripMetaData)
        {
            Console.WriteLine("Based on default strategy, price is 100");
            return 100.00;
        }
    }
}
