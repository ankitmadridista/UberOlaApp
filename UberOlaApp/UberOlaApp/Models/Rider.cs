using UberOlaApp.Common;

namespace UberOlaApp.Models
{
    public class Rider
    {
        string name { get; }
        RATING rating { get; }

        public Rider(string name, RATING rating)
        {
            this.name = name;
            this.rating = rating;
        }



        //Rider(string pName, RATING pRating) : name(pName), rating(pRating) { }
        //    string getRiderName()
        //    {
        //        return name;
        //    }
        //    RATING getRating()
        //    {
        //        return rating;
        //    }
    }
}
