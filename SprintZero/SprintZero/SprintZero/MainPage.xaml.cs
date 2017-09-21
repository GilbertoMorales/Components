using Tools.Plugins.ExternalMaps;
using Xamarin.Auth;
using Xamarin.Forms;

namespace SprintZero
{
    public partial class MainPage : ContentPage
    {
        const string ServiceId = "ComicBook";
        const string Scope = "profile";
        Account account;
        AccountStore store = null;

        public MainPage()
        {
            InitializeComponent();
            ButtonMapsExternal.Clicked += ButtonMapsExternal_Clicked;
            ButtonOAuth.Clicked += ButtonOAuth_Clicked;
        }

        private void ButtonOAuth_Clicked(object sender, System.EventArgs e)
        {
          
        }
       

        private void ButtonMapsExternal_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IExternalMaps>().NavigateTo("Xamarin", 25.640491, -100.280269);
        }
    }
}
