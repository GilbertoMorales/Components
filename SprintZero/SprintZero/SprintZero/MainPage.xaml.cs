using Tools.Plugins.ExternalMaps;
using Xamarin.Forms;

namespace SprintZero
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonMapsExternal.Clicked += ButtonMapsExternal_Clicked;
        }

        private void ButtonMapsExternal_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IExternalMaps>().NavigateTo("Xamarin", 25.640491, -100.280269) ;
        }
    }
}
