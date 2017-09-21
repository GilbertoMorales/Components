using System;
using Tools.Plugins.ExternalMaps;
using Xamarin.Forms;

namespace SprintZero.ViewModels
{
    public class MapsExternalViewModel : BindableBase
    {

        #region Constructor
        public MapsExternalViewModel()
        {
            CommandMap = new Command(UnfoldMap);
        }
        #endregion

        #region Methods
        private void UnfoldMap(object obj)
        {
            DependencyService.Get<IExternalMaps>().NavigateTo("Xamarin Maps", 25.640491, -100.280269);
        }
        #endregion

        #region Commands

        public Command CommandMap { set; get; }

        #endregion
    }
}
