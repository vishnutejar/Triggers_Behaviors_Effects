using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Triggers_Behaviors_Effects
{
    public class TriggerActionCustom : TriggerAction<Button>
    {
        protected async override void Invoke(Button sender)
        {
           await sender.ScaleTo(0.95, 50, Easing.CubicInOut);
           await sender.ScaleTo(1, 50, Easing.CubicInOut);
        }
    }
}
