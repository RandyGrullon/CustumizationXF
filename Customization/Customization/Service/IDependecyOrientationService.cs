using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Customization.Service
{
    public interface IDependecyOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
