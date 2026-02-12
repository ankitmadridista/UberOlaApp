using UberOlaApp.Common.Enums;

namespace UberOlaApp.Models
{
    public class TripMetaData
    {
        public Location SrcLoc { get; set; }
        public Location DstLoc { get; set; }
        public EnRATING RiderRating { get; }
        public EnRATING DriverRating { get; set; }

        public TripMetaData(Location SrcLock, Location DstLoc,
            EnRATING RiderRating) 
        {
            this.DriverRating = RiderRating;
        }

        public EnRATING GetRiderRating()
        {
            return RiderRating;
        }

        public EnRATING GetDriverRating()
        {
            return DriverRating;
        }

        public void SetDriverRating(EnRATING rating)
        {
            this.DriverRating = rating;
        }
    }
}
