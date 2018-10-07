using System;
using Plugin.Geolocator;    
using Plugin.Geoposition;

namespace DriveBy
{
    public static class Surroundings
    {
        Geolocator geolocator;
        Geoposition geoposition;
        public MainPage()
        {
            this.InitializeComponent();
            geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 10;
            geolocator.ReportInterval = 0;

            myButton.Click += async (sender, e) =>
            {
                geoposition = await geolocator.GetGeopositionAsync();
                string latitude = geoposition.Coordinate.Latitude.ToString("0.0000000000");
                string Longitude = geoposition.Coordinate.Longitude.ToString("0.0000000000");
                string Accuracy = geoposition.Coordinate.Accuracy.ToString("0.0000000000");
            };
        }

        public double[] space()
        {
            double holdLat = latitude;
            double holdLon = Longitude;
            double latIncrease = (5 / 68.99);
            double lonIncrease = (5 / 53.06);
            double c2 = Math.Pow(latIncrease + lonIncrease, 2);
            double c = Math.sqrt(c2);
            if (holdLat > latitude && holdLon > Longitude)
            {
                return [latitude - c, longitude - c];
            } else if (holdLat < latitude && holdLon < longitude)
            {
                return [latitude + c, longitude + c];
            } else if (holdLat > latitude && holdLon < Longitude)
            {
                return [latitude - c, Longitude + c];
            } else if (holdLat < latitude && holdLon > Longitude)
            {
                return [latitude + c, Longitude - c];
            }
        }   
        
        
    }
}