using Plugin.Connectivity;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SprintZero.ViewModels
{
    public class ConnectivityViewModel : BindableBase
    {

        #region Constructor
        public ConnectivityViewModel()
        {
            //CommandTets = new Command(async () => await ConnectivityTest());
            CommandTets = new Command(ConnectivityTest);
        }
        #endregion

        #region Methods
        private void ConnectivityTest()
        {
            IsSupport = CrossConnectivity.IsSupported;

            var stateConneted = CrossConnectivity.Current.IsConnected ? "Connected" : "No Connection";
            IsConneted = ("Is Connected " + stateConneted);

            BandWidths = "Bandwidths: ";
            foreach (var band in CrossConnectivity.Current.Bandwidths)
            {
                BandWidths += band.ToString() + ", ";
            }

            ConnectionTypes = "ConnectionTypes:  ";
            foreach (var band in CrossConnectivity.Current.ConnectionTypes)
            {
                ConnectionTypes += band.ToString() + ", ";
            }
            
        }
        #endregion

        #region Properties

        private bool isSupport = false;

        public bool IsSupport
        {
            get { return isSupport; }
            set { isSupport = value;
                RaisePropertyChangedEventHandler();
            }
        }

        private string isConneted;

        public string IsConneted
        {
            get { return isConneted; }
            set { isConneted = value;
                RaisePropertyChangedEventHandler();
            }
        }

        private string bandWidths;

        public string BandWidths
        {
            get { return bandWidths; }
            set { bandWidths = value;
                RaisePropertyChangedEventHandler();
            }
        }

        private string connectionTypes;

        public string ConnectionTypes
        {
            get { return connectionTypes; }
            set { connectionTypes = value;
                RaisePropertyChangedEventHandler();
            }
        }

        #endregion

        #region Commands

        public Command CommandTets { set; get; }

        #endregion



    }
}
