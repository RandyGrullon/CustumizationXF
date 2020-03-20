using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Customization.iOS.Service;
using Customization.Service;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

[assembly: Dependency(typeof(DeviceOrientationService))]

namespace Customization.iOS.Service
{
    public class DeviceOrientationService : IDependecyOrientationService
    {


        public DeviceOrientation GetOrientation()
        {
            var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

            return !isPortrait ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }
    }
}