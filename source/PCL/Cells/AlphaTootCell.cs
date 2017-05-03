using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using seven.trumpets.Domain;
using RuyiJinguBang;

namespace seven.trumpets
{
    public class AlphaTootCell : ViewCell
    {
        public AlphaImageView IconImage = new AlphaImageView();
        public Label DisplayNameLabel = new Label();
        public Label PreferredUsernameLabel = new Label();
        public Label TimeLabel = new Label();
        public Label TootTextLabel = new Label();

        public AlphaTootCell()
        {
            IconImage.IsCircle = true;
            IconImage.EnabledAnimation = true;
            IconImage.VerticalOptions = LayoutOptions.Start;
            IconImage.WidthRequest = 32;
            IconImage.HeightRequest = 32;
            AlphaImageProxy.Get("https://ika.queloud.net/system/accounts/avatars/000/000/222/original/5ba253f596e7ce8f.png?1493388960")
                .ContiuneWithOnUIThread(t => IconImage.ImageBytes = t.Result);
            DisplayNameLabel.HorizontalOptions = LayoutOptions.Start;
            PreferredUsernameLabel.HorizontalOptions = LayoutOptions.StartAndExpand;
            PreferredUsernameLabel.TextColor = Color.Gray;
            TimeLabel.HorizontalOptions = LayoutOptions.End;
            View = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(10, 4, 0, 4),
                Children = {
                    IconImage,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        Children =
                        {
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    DisplayNameLabel,
                                    PreferredUsernameLabel,
                                    TimeLabel,
                                }
                            },
                            TootTextLabel,
                        }
                    }
                }
            };
        }
        public string DisplayName
        {
            get
            {
                return DisplayNameLabel.Text;
            }
            set
            {
                DisplayNameLabel.Text = value;
            }
        }
        public string PreferredUsername
        {
            get
            {
                return PreferredUsernameLabel.Text;
            }
            set
            {
                PreferredUsernameLabel.Text = value;
            }
        }
        public string Time
        {
            get
            {
                return TimeLabel.Text;
            }
            set
            {
                TimeLabel.Text = value;
            }
        }
        public string TootText
        {
            get
            {
                return TootTextLabel.Text;
            }
            set
            {
                TootTextLabel.Text = value;
            }
        }
    }
}

