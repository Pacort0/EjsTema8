namespace EjsTema8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayout());
        }

        private async void Button_2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout1());
        }
    }
}