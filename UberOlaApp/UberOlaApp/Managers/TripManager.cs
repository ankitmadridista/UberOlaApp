using UberOlaApp.Models;
using UberOlaApp.Strategy;

namespace UberOlaApp.Managers
{
    public class TripManager
    {
        public static TripManager? Instance;

        RiderManager riderManager;
        DriverManager driverManager;
        Dictionary<int, TripMetaData> tripsMetaDataInfo;
        Dictionary<int, Trip> tripsInfo;

        public TripManager()
        {
            //RiderManager = getRider

        }

        public static TripManager GetTripManager()
        {
            using (Mutex mutex = new Mutex(false, "MutexDemo"))
            {
                if (Instance == null)
                {
                    mutex.WaitOne(1000);
                    if (Instance == null)
                    {
                        Instance = new TripManager();
                        Instance.tripsInfo = new Dictionary<int, Trip>();
                        Instance.tripsMetaDataInfo = new Dictionary<int, TripMetaData>();
                    }
                }
            }
            return Instance;
        }

        public void CreateTrip(Rider rider, Location srcLoc, Location dstLoc)
        {
            TripMetaData metaData = new TripMetaData(srcLoc,dstLoc,rider.Rating);
            StrategyManager strategyManager = StrategyManager.GetStrategyManager();
            IPricingStrategy pricingStrategy = strategyManager.DeterminePricingstrategy(metaData);
            IDriverMatchingStrategy driverMatchingStrategy = strategyManager.DetermineMatchingStrategy(metaData);

            Driver driver = driverMatchingStrategy.MatchDriver(metaData);
            double tripPrice = pricingStrategy.CalculatePrice(metaData);

            Trip trip = new Trip(rider, driver, srcLoc, dstLoc, tripPrice, pricingStrategy, driverMatchingStrategy);
            int tripId = trip.GetTripId();
            tripsInfo[tripId] = trip;
            tripsMetaDataInfo[tripId] = metaData;       

        }

        public Dictionary<int, Trip> GetTripsMap()
        {
            return tripsInfo;
        }
    }
}
