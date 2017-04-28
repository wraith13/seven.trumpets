using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace seven.trumpets.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        AlphaApp App;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            LoadApplication(MakeSureApp());

            return base.FinishedLaunching(app, options);
        }
        public AlphaApp MakeSureApp()
        {
            if (null == App)
            {
                global::Xamarin.Forms.Forms.Init();
                //ImageCircleRenderer.Init();
                OmegaFactory.MakeSureInit();
                App = AlphaFactory.MakeSureApp();
            }
        return App;
        }
    }
}
