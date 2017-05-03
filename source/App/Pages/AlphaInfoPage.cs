using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaInfoPage : ResponsiveContentPage
    {
        public AlphaInfoPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaInfoPage" }
                }
            };
        }
    }
}

