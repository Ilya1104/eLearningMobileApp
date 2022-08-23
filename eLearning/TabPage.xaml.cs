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
    public partial class TabPage : Shell
    {
       
        public TabPage()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
            Routing.RegisterRoute(nameof(PracticePage), typeof(PracticePage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}