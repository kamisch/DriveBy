using System;
using UIKit;
using Xamarin.Forms.Maps;
using DriveBy.MapStuff;

namespace DriveBy
{
    public class Maps
    {
        public Maps()
        {
            
        }
        
        public void LocationToPin()
        {
        
        }
        
        public void LocationToPinArray(MapData mapData)
        {
            Pin pin = new Pin (){
            Position = new Position (37, -122),
            Label = "Some Pin!"
            };
            
            
        }
        
        public static void AddressToLatLong(MapData[] mapData)
        {
            var address = "Stavanger, Norway";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);
        
            var latitude = point.Latitude;
            var longitude = point.Longitude;
        }
    }
}
