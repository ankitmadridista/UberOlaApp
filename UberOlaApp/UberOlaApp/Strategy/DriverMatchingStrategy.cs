using UberOlaApp.Models;

namespace UberOlaApp.Strategy
{
    public interface IDriverMatchingStrategy
    {
        public Driver MatchDriver(TripMetaData tripMetaData);
    }
}
