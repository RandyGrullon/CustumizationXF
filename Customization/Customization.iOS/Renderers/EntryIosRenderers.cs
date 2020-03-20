﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Customization.Controls;
using Customization.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(EntryRenders), typeof(EntryIosRenderers))]
namespace Customization.iOS.Renderers
{
    public class EntryIosRenderers:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}