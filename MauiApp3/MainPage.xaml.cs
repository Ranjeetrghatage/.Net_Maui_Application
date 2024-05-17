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

        private void OnButtonTapped(object sender, TappedEventArgs e)
        {
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

        private void Settings_Clicked(object sender, EventArgs e)
        {
            var frame = new Frame
            {
                BorderColor = Colors.Transparent,
                BackgroundColor = Colors.Transparent,
                //Style = (Style)Application.Current.Resources["ImageFrame"],
                
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

            var lastFrame = GalleryGrid.Children[GalleryGrid.Children.Count - 1] as Frame;
            int CurrNumber = 0;
            if (lastFrame != null && lastFrame.Content is Grid lastFrameGrid)
            {
                string lastFrameLabelText = lastFrameGrid.Children.OfType<Label>().FirstOrDefault().Text;
                int firstSpaceIndex = lastFrameLabelText.IndexOf(" ");
                CurrNumber = int.Parse(lastFrameLabelText.Substring(firstSpaceIndex + 1));
            }

            var label = new Label
            {
                Text = $"Stream {CurrNumber+1}",
                TextColor = Colors.White,
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.Start,
                Margin = new Thickness(20, 90, 10, 20)
            };

            grid.Children.Add(image);
            grid.Children.Add(label);
            frame.Content = grid;

            GalleryGrid.SetRow(frame, 2);
            GalleryGrid.SetColumn(frame, 0);

            GalleryGrid.Children.Add(frame);



          





        }



    }

}
