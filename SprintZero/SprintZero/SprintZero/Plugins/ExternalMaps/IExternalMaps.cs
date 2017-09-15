using System.Threading.Tasks;

namespace Tools.Plugins.ExternalMaps
{
    public interface IExternalMaps
    {
        Task<bool> NavigateTo(string name, double latitude, double longitude, NavigationType navigationType = NavigationType.Default);

        Task<bool> NavigateTo(string name, string street, string city, string state, string zip, string country, string countryCode, NavigationType navigationType = NavigationType.Default);
    }
}
