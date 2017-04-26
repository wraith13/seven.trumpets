using System;

using Xamarin.Forms;

namespace seven.trumpets
{
    public class AlphaTimelinePage : ContentPage
    {
        public AlphaTimelinePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

