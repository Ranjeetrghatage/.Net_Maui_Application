namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonTapped(object sender, TappedEventArgs e)
        {
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        //private void OnAddStreamClicked(object sender, EventArgs e)
        //{
        //    var newFrame = new Frame
        //    {
        //        BackgroundColor = Colors.Black,
        //        Content = new Grid
        //        {
        //            Children =
        //            {
        //                new Image
        //                {
        //                    Source = $"stream.jpg",
        //                    Aspect = Aspect.AspectFill
        //                },
        //                new Label
        //                {
        //                    Text = $"Stream",
        //                    TextColor = Colors.White,
        //                    VerticalOptions = LayoutOptions.End,
        //                    HorizontalOptions = LayoutOptions.Start,
        //                    Margin = new Thickness(10)
        //                }
        //            }
        //        }
        //    };
        //    StreamContainer.Children.Add(newFrame);
        //}




    }

}
