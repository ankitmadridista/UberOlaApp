using UberOlaApp.Common;

namespace UberOlaApp.Models
{
    public class Driver
    {
        string name { get; }
        bool avail;
        RATING RATING { get; }

        public Driver(string name, RATING rating)
        {
            this.name = name;
            this.RATING = rating;
            this.avail = false;
        }

        void UpdateAvail(bool avail)
        {
            this.avail = avail;
        }
    }
}
