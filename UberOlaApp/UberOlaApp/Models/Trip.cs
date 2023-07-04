using UberOlaApp.Common;

namespace UberOlaApp.Models
{
    public class Trip
    {
        Rider Rider { get; set; }
        Driver driver { get; set; }

        Location location { get; set; }

        TRIP_STATUS sTATUS { get; set; }

        int TripId { get; set; }
        double price { get; set; }


    }
}
