using Android.Content;
using Android.Runtime;
using Android.Views;
using Customization.Droid.Service;
using Customization.Service;
using Xamarin.Forms;
using Xamarin.Forms.Internals;


[assembly: Dependency(typeof(DeviceOrientationService))]

namespace Customization.Droid.Service
{
    public class DeviceOrientationService : IDependecyOrientationService
    {


        public DeviceOrientation GetOrientation()
        {

            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;


            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;

            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;

        }
    }
}