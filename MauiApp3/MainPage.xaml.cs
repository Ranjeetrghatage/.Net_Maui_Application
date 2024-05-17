using Microsoft.Maui.Controls;
using System.Data.Common;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }



        private async void OnAddButtonTapped(object sender, TappedEventArgs e)
        {
            var lastFrame = GalleryGrid.Children[GalleryGrid.Children.Count - 1] as Frame;
            int CurrNumber = 0;
            if (lastFrame != null && lastFrame.Content is Grid lastFrameGrid)
            {
                string lastFrameLabelText = lastFrameGrid.Children.OfType<Label>().FirstOrDefault().Text;
                int firstSpaceIndex = lastFrameLabelText.IndexOf(" ");
                CurrNumber = int.Parse(lastFrameLabelText.Substring(firstSpaceIndex + 1)) + 1; //Current Frame Number
            }

            int ColumnNumber = 1;
            if (CurrNumber % 2 != 0)       
            {
                GalleryGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ColumnNumber = 0;
            }




            var frame = new Frame
            {
                BorderColor = Colors.Transparent,
                BackgroundColor = Colors.Transparent,
            };

            var grid = new Grid
            {
                Padding = new Thickness(-10, -10, -10, 0),
                Margin = new Thickness(0, 1 == 0 ? 0 : -22, -15, 0)
            };

            var image = new Image
            {
                Source = "imageSource",
                Aspect = Aspect.Fill,
                Background = Colors.Black
            };

      
            var label = new Label
            {
                Text = $"Stream {CurrNumber}",
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.Start,
                Margin = new Thickness(20, 90, 10, 20)
            };

            grid.Children.Add(image);
            grid.Children.Add(label);
            frame.Content = grid;

            GalleryGrid.SetRow(frame, (int)Math.Ceiling((CurrNumber / 2.0) - 1));
            GalleryGrid.SetColumn(frame, ColumnNumber);

            GalleryGrid.Children.Add(frame);

            //Toaster
            ToasterLabel.Text = "Sucess...";
            ToasterFrame.IsVisible = true;
            await Task.Delay(2000);
            ToasterFrame.IsVisible = false;

        }


        private async void Settings_Clicked(object sender, EventArgs e)
        {
            ClearGridExceptFirstFour();

            var button = (ImageButton)sender;
            await button.RotateTo(360, 1000);
            button.Rotation = 0;

            ToasterFrame.WidthRequest = 150;
            ToasterLabel.Text = "Added Streams Cleared...";
            ToasterFrame.IsVisible = true;
            await Task.Delay(2000);
            ToasterFrame.IsVisible = false;
            ToasterFrame.WidthRequest = 80;

        }


        public void ClearGridExceptFirstFour()
        {
            if (GalleryGrid.Children.Count > 4)
            {
                for (int i = GalleryGrid.Children.Count - 1; i >= 4; i--)
                {
                    GalleryGrid.Children.RemoveAt(i);
                }
            }
        }


        private void SwitchOff_Clicked(object sender, EventArgs e)
        {
            ExitBorder.IsVisible = true;
        }


        private void SwitchOffOK_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SwitchOffCancel_Clicked(object sender, EventArgs e)
        {
            ExitBorder.IsVisible = false;

        }

    



    }

}
