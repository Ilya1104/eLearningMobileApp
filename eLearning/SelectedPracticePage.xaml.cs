using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLearning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedPracticePage : ContentPage
    {
        public SelectedPracticePage()
        {
            InitializeComponent();
        }
        Image[] images = new Image[6];
        protected async override void OnAppearing()
        {
            images[0] = i1;
            images[1] = i2;
            images[2] = i3;
            images[3] = i4;
            images[4] = i5;
            images[5] = i6;

        //  ll.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "eLearning.sqlite");
            for (int i = 0; i < images.Length; i++)
            {
                if (images[i].Source is null)
                {
                    images[i].WidthRequest = 0;
                    images[i].HeightRequest = 0;
                }
            }
        }
    }
}