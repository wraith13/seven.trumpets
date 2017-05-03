using System;

using Xamarin.Forms;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaPostPage : ResponsiveContentPage
    {
        public AlphaPostPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "AlphaPostPage" }
                }
            };
        }
    }
}

