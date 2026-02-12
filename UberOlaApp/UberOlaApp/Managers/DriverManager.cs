using System.Threading;
using UberOlaApp.Models;

namespace UberOlaApp.Managers
{
    public class DriverManager
    {
        public DriverManager() { }

        static DriverManager driverMgrInstance;
        Dictionary<string, Driver> driversMap;

        public static DriverManager GetDriverManager()
        {
            using (Mutex mtx = new Mutex(false, "MutexDemo"))
            {
                if (driverMgrInstance == null)
                {
                    mtx.WaitOne();
                    if (driverMgrInstance == null)
                    {
                        driverMgrInstance = new DriverManager();
                    }
                    mtx.ReleaseMutex();
                }
            }
            return driverMgrInstance;
        }

        public void AddDriver(string driverName, Driver driver)
        {
            if (driversMap != null)
            {
                driversMap[driverName] = driver;
             }
            else { 
                driversMap = new Dictionary<string, Driver>();
                driversMap[driverName] = driver;
            }
            
        }

        public Driver GetDriverByName(string driverName)
        {
            return driversMap[driverName];
        }

        public Dictionary<string, Driver> GetDrivesMap()
        {
            return driversMap;
        }


    }
}
