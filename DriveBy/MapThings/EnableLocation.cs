using System;
using Xamarin.Essentials;
using Plugin.Geolocator;
using Xamarin.Forms.Map;

namespace DriveBy.MapStuff
{
    public class EnableLocation
    {
        public EnableLocation(Map map)
        {
            CLLocationManager locationManager = new CLLocationManager();
            locationManager.RequestWhenInUseAuthorization();
            map.ShowsUserLocation = true;
            
            // add an annotation
            map.AddAnnotations (new MKPointAnnotation (){
                Title="MyAnnotation",
                Coordinate = new CLLocationCoordinate2D (42.364260, -71.120824)
            });
        }
    }
}
}
