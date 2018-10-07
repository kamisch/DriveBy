using System;

namespace DriveBy.MapThings
{
    public class MapData
    {
        public double Latitude {get;set;}
        public double Longitude {get;set;}
        public string RestaurantType{get;set;}
        public string RestaurantName{get;set;}
        
        public MapData(double latitude,double longitude,string restaurantName,string restaurantType)
        {
            Latitude=latitude;
            Longitude=longitude;
            RestaurantType=restaurantType;
            RestaurantName=restaurantName;
        }
    }
}
