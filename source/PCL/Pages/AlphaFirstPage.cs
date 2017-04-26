using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaFirstPage : ResponsiveContentPage
    {
        public AlphaFirstPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaFirstPage" }
                }
            };
        }
    }
}

