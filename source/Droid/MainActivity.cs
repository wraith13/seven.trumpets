using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace seven.trumpets.Droid
{
    [Activity(Label = "seven.trumpets.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        AlphaApp App;

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            LoadApplication(MakeSureApp(bundle));
        }
        public AlphaApp MakeSureApp(Bundle bundle)
        {
            if (null == App)
            {
                global::Xamarin.Forms.Forms.Init(this, bundle);
                //ImageCircleRenderer.Init();
                OmegaFactory.MakeSureInit();
                App = AlphaFactory.MakeSureApp();
            }
            return App;
        }
    }
}
