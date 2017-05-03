using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaApp : Application
    {
        public AlphaApp()
        {
            // The root page of your application
            var content = new ContentPage
            {
                Title = "seven.trumpets",
                //*
                Content = new ListView
                {
                    HasUnevenRows = true,
                    ItemTemplate = new DataTemplateEx(typeof(AlphaTootCell))
                        .SetBindingList
                        (
                            "DisplayName",
                            "PreferredUsername",
                            "TootText"
                        ),
                    ItemsSource = new[]
                    {
                        new
                        {
                            DisplayName = "道化師",
                            PreferredUsername = "@wraith13",
                            TootText = "ᔦꙬᔨ",
                        },
                        new
                        {
                            DisplayName = "道化師",
                            PreferredUsername = "@wraith13",
                            TootText = "(◔⊖◔)！",
                        },
                    }
                }
                /*/Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }//*/
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
