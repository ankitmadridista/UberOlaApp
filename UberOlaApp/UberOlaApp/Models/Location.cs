namespace UberOlaApp.Models
{
    public class Location
    {
        public double latitude { get; }
        public double longitude { get; }
        
        public Location(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
