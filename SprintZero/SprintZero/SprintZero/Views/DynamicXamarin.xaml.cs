using SprintZero.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SprintZero.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicXamarin : ContentPage
    {
        public DynamicXamarin()
        {
            InitializeComponent();
            RefreshView();
        }


        public async Task RefreshView()
        {
            await Task.Run(async () =>
             {
                 await Task.Delay(10000);

                 Device.BeginInvokeOnMainThread(() =>
                 {
                     var content = new ContentPage();
                     var stream = this.GetType().GetTypeInfo().Assembly.GetManifestResourceStream("SprintZero.Main.xaml");
                     var xaml = new StreamReader(stream).ReadToEnd();

                     content.LoadFromXaml(xaml);
                     Content = content.Content;
                 });
             });
        }
    }
}