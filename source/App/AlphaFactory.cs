using System;
using System.Linq;
using Xamarin.Forms;
//using ImageCircle.Forms.Plugin.Abstractions;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using seven.trumpets.Domain;

namespace seven.trumpets
{
    public abstract class AlphaFactory
    {
        static AlphaFactory Instance = null;
        AlphaApp App = null;
        //Languages.AlphaLanguage Language = null;

        public AlphaFactory()
        {
        }
        protected static void Init(AlphaFactory Factory)
        {
            Instance = Factory;
            AlphaFactory.MakeSureDomain();
        }
        public static AlphaFactory Get()
        {
            return Instance;
        }

        public static AlphaDomain MakeSureDomain()
        {
            return AlphaDomain.Get() ?? Instance.MakeOmegaDomain();
        }
        public abstract AlphaDomain MakeOmegaDomain();

        public static AlphaApp GetApp()
        {
            return Instance.App;
        }
        public static AlphaApp SetApp(AlphaApp app)
        {
            return Instance.App = app;
        }
        public static AlphaApp MakeSureApp()
        {
            return Instance.App ??
                SetApp(Instance.MakeOmegaApp());
        }
        public abstract AlphaApp MakeOmegaApp();

        //public static Languages.AlphaLanguage MakeSureLanguage()
        //{
        //    return Instance.Language ??
        //        (Instance.Language = Instance.MakeOmegaLanguage());
        //}
        //public virtual Languages.AlphaLanguage MakeOmegaLanguage()
        //{
        //    return new Languages.AlphaLanguage();
        //}

        public static AlphaFirstPage MakeFirstPage()
        {
            return Instance.MakeOmegaFirstPage();
        }

        public virtual AlphaFirstPage MakeOmegaFirstPage()
        {
            return new AlphaFirstPage();
        }

        public static ContentPage MakeSettingsPage()
        {
            return Instance.MakeOmegaSettingsPage();
        }
        public virtual ContentPage MakeOmegaSettingsPage()
        {
        return new AlphaSettingsPage();
        }

        public static AlphaInfoPage MakeInfoPage()
        {
            return Instance.MakeOmegaInfoPage();
        }
        public virtual AlphaInfoPage MakeOmegaInfoPage()
        {
            return new AlphaInfoPage();
        }

        public static async Task<ImageSource> MakeImageSourceFromUrl(string Url)
        {
            return await Instance.MakeOmegaImageSourceFromUrl(Url);
        }
        public virtual async Task<ImageSource> MakeOmegaImageSourceFromUrl(string Url)
        {
            //return ImageSource.FromUri(new Uri(Url));
            //  ↑こちらのコードでも良いが、効率化の為に SkiaSharp 用のバイナリと同じモノを使い回す
            var Binary = await AlphaImageProxy.Get(Url);
            if (Binary?.Any() ?? false)
            {
                return ImageSource.FromStream(() => new System.IO.MemoryStream(Binary));
            }
            else
            {
                Debug.WriteLine($"MakeOmegaImageSourceFromUrl(\"{Url}\") is failed");
            }
            return null;
        }
    }
}

