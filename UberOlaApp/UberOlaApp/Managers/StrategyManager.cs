using System.Xml;
using UberOlaApp.Models;
using UberOlaApp.Strategy;

namespace UberOlaApp.Managers
{
    public class StrategyManager
    {
        static StrategyManager strategyManager;

        public StrategyManager()
        {

        }

        public static StrategyManager GetStrategyManager()
        {
            if (strategyManager == null)
            {
                using (Mutex mtx = new Mutex(false, "MutexDemo"))
                {
                    mtx.WaitOne(1000);
                    if (strategyManager == null)
                    {
                        strategyManager = new StrategyManager();
                    }
                    mtx.ReleaseMutex();

                }
            }
            return strategyManager;
        }

        public IPricingStrategy DeterminePricingstrategy(TripMetaData metaData)
        {
            Console.WriteLine();
            return new DefaultPricingStrategy();
        }


        public IDriverMatchingStrategy DetermineMatchingStrategy(TripMetaData metaData)
        {
            Console.WriteLine("Based on location and other factors, setting matching strategy");
            return new LeastTimeBasedMatchingStrategy();
        }


    }
}
