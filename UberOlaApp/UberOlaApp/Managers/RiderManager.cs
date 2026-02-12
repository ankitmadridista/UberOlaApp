using UberOlaApp.Models;

namespace UberOlaApp.Managers
{
    public class RiderManager
    {
        public RiderManager()
        {
            
        }
        static RiderManager riderManager;
        static Mutex mutex;

        public Dictionary<string, Rider> ridersMap;

        public static RiderManager GetRiderManager()
        {
            using (Mutex mutex = new Mutex(false, "MutexDemo"))
            {
                if (riderManager == null)
                {
                    mutex.WaitOne(1000);
                    if (riderManager == null)
                    {
                        riderManager = new RiderManager();
                    }
                    mutex.ReleaseMutex();

                }
            }
            return riderManager;
        }

        public void AddRider(string riderName, Rider rider)
        {
            if (ridersMap != null)
            {
                ridersMap[riderName] = rider;
            }
            else
            {
                ridersMap = new Dictionary<string, Rider>();
                ridersMap[riderName] = rider;
            }
            
        }

        public Rider GetRider(string riderName)
        {
            return ridersMap[riderName];
        }
    }


}
