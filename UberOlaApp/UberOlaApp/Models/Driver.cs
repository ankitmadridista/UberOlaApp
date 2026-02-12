using UberOlaApp.Common.Enums;

namespace UberOlaApp.Models
{
    public class Driver
    {
        public string Name { get; }
        public bool avail;
        public EnRATING RATING { get; }
        public Driver()
        {
            
        }

        public Driver(string name, EnRATING rating)
        {
            this.Name = name;
            this.RATING = rating;
            this.avail = false;
        }

        void UpdateAvail(bool avail)
        {
            this.avail = avail;
        }
    }
}
