using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaSettingsPage : ResponsiveContentPage
    {
        public AlphaSettingsPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaSettingsPage" }
                }
            };
        }
    }
}

