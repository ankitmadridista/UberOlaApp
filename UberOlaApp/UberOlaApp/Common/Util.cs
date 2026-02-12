using Microsoft.AspNetCore.Components.Web;
using UberOlaApp.Common.Enums;

namespace UberOlaApp.Common
{
    public class Util
    {
        public static string RatingToString(EnRATING enRATING)
        {
            if (enRATING == EnRATING.ONE_STAR)
                return "One Star";
            if (enRATING == EnRATING.TWO_STARS)
                return "Two Stars";
            if (enRATING == EnRATING.THREE_STARS)
                return "Three Stars";
            if (enRATING == EnRATING.FOUR_STARS)
                return "Four Stars";
            if (enRATING == EnRATING.FIVE_STARS)
                return "Five Stars";
            return "Invalid Rating";
        }

        public static bool IsHighRating(EnRATING RATING)
        {
            return RATING == EnRATING.FOUR_STARS || RATING == EnRATING.FIVE_STARS;
        }
    }
}
