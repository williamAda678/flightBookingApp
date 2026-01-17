using System;
using backend.Model;

namespace backend.Extensions;

public class Helper
{
    public static double GetDistanceBetweenAirports(Airport ori, Airport des)
    {
        double EarthRadiusKm = 6371.0;
        double LatitudeDistance = (des.Latitude - ori.Latitude) * Math.PI / 180.0;
        double LongitudeDistance = (des.Longitude - ori.Longitude) * Math.PI / 180.0;

        double a = Math.Sin(LatitudeDistance / 2)
                 * Math.Sin(LatitudeDistance / 2)
                 + Math.Cos(des.Latitude * Math.PI / 180.0)
                 * Math.Cos(ori.Latitude * Math.PI / 180.0)
                 * Math.Sin(LongitudeDistance / 2)
                 * Math.Sin(LongitudeDistance / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return EarthRadiusKm * c;
    }

    public static double GetFightTimeBetweenAirports(Airport ori, Airport des, Aircraft aircraft)
    {
        var distance = GetDistanceBetweenAirports(ori, des);
        var time = distance / aircraft.CruiseSpeedKmh;

        return time;
    }

}
