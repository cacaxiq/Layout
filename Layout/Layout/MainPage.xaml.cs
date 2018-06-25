using Xamarin.Forms;

namespace Layout
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            listView.ItemsSource = GeradorFeed.ListaFeed();
		}
	}
}
