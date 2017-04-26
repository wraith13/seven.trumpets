using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaSelectServerPage : ResponsiveContentPage
    {
        public AlphaSelectServerPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaSelectServerPage" }
                }
            };
        }
    }
}

