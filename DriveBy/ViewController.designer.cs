﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace DriveBy
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISearchBar DestinationBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView RestaurantMap { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIScrollView ResultList { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DestinationBar != null) {
                DestinationBar.Dispose ();
                DestinationBar = null;
            }

            if (RestaurantMap != null) {
                RestaurantMap.Dispose ();
                RestaurantMap = null;
            }

            if (ResultList != null) {
                ResultList.Dispose ();
                ResultList = null;
            }
        }
    }
}