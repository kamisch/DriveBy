using System;
using Plugin.Geolocator;

namespace DriveBy.MapStuff
{
    public class EnableLocation
    {
        public EnableLocation()
        {
            var locator = CrossGeolocator.Current;
 
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            
            locator.PositionChanged += (sender, e) => 
            {
                var position = e.Position;
                
                latitudeLabel.Text = position.Latitude;
                longitudeLabel.Text = position.Longitude;
            };
        }
    }
}
