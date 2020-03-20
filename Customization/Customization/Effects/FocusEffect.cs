using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Customization.Effects
{
    public class FocusEffect: RoutingEffect
    {
        public FocusEffect() : base($"Customization.{nameof(FocusEffect)}")
        {
        }
    }
}
