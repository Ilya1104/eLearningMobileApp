using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLearning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public string userNickName;
        public RegistrationPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
           
        }
       
    }
}