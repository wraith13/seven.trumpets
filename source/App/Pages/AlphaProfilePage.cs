using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaProfilePage : ResponsiveContentPage
    {
        public AlphaProfilePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaProfilePage" }
                }
            };
        }
    }
}

