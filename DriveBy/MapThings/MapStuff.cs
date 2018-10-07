using System;
using UIKit;
using Xamarin.Forms.Maps;


namespace DriveBy
{
    public class MapStuff
    {
        public MapStuff()
        {
            
        }
        
        public void LocationToPin()
        {
        
        }
        
        public void LocationToPinArray()
        {
            Pin pin = new Pin (){
            Position = new Position (37, -122),
            Label = "Some Pin!"
            };
            
            
        }
        
        public static void AddressToLatLong()
        {
            var address = "Stavanger, Norway";

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);
        
            var latitude = point.Latitude;
            var longitude = point.Longitude;
        }
    }
}
