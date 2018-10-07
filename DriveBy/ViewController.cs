using System;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Input;

using UIKit;

namespace DriveBy
{
 
   public partial class ViewController : UIViewController
    {
        
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
            
        }
        
        private void SearchBar_OnTextChanged(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                
            }
            
            
           Console.Write("A");
           //RestaurantMap
        }

        private double[] addressToLatLon(string address)
        {
            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var latitude = point.Latitude;
            var longitude = point.Longitude;
            
            return [latitude, longitude];
        }
        
        
        
    }
}



