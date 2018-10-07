using System;

using UIKit;

namespace DriveBy
{
 
   public partial class ViewController : UIViewController
    {
        
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic
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
        
        private void SearchBar_OnTextChanged(object sender, UIReturnKeyType e)
        {
           //create destination
           //after destination, returns array of Locations
           Console.Write("A");
           //Rest
        }
    }
}



