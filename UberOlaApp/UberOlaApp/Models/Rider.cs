using UberOlaApp.Common.Enums;

namespace UberOlaApp.Models
{
    public class Rider
    {
        public string Name { get; }
        public EnRATING Rating { get; }

        public Rider(string name, EnRATING rating)
        {
            this.Name = name;
            this.Rating = rating;
        }

    }
}
