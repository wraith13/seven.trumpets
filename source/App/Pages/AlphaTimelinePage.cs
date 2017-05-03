using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaTimelinePage : ResponsiveContentPage
    {
        public AlphaTimelinePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaTimelinePage" }
                }
            };
        }
    }
}

