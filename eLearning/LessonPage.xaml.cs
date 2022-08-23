using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLearning
{
    public partial class LessonPage : ContentPage
    {
        Image[] images = new Image[4];
        public LessonPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            images[0] = i1;
            images[1] = i2;
            images[2] = i3;
            images[3] = i4;

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