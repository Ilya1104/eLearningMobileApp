using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLearning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialPage : ContentPage
    {
       

        public InitialPage()
        {
            InitializeComponent();
        }
        public void QuitApp(object sender, EventArgs args)
        {
            Process.GetCurrentProcess().CloseMainWindow();
            Process.GetCurrentProcess().Close();
        }
        private async void ToRegistrationPage(object sender, EventArgs e)
        {
          
            await Navigation.PushAsync(new RegistrationPage());
        }
        private async void ToAuthorizationPage(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TabPage();
        }
    }
}