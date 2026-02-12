using UberOlaApp.Models;

namespace UberOlaApp.Strategy
{
    public interface IPricingStrategy
    {
        public double CalculatePrice(TripMetaData tripMetaData); 
    }
}
