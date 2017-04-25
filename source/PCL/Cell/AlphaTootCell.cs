using System;

using Xamarin.Forms;

namespace seven.trumpets
{
    public class AlphaTootCell : ViewCell
    {
        public Image IconImage = new Image();
        public Label DisplayNameLabel = new Label();
        public Label PreferredUsernameLabel = new Label();
        public Label TimeLabel = new Label();
        public Label TootTextLabel = new Label();

        public AlphaTootCell()
        {
            IconImage.VerticalOptions = LayoutOptions.Start;
            IconImage.WidthRequest = 32;
            IconImage.HeightRequest = 32;
            IconImage.Source = ImageSource.FromUri(new Uri("https://ika.queloud.net/system/accounts/avatars/000/000/222/original/825e1a69736038a7.png?1492516741"));
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

