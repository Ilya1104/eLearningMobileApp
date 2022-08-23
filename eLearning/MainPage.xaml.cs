using System;
using c = System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eLearning
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }        
        protected override async void OnAppearing()
        {
             await App.LectionDatabase.CreateTable();
            friendsList.ItemsSource = await App.LectionDatabase.GetItemsAsync(); base.OnAppearing();
        }
        
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Lesson selectedLesson = (Lesson)e.SelectedItem;
            LessonPage lessonPage = new LessonPage();
            lessonPage.BindingContext = selectedLesson;
            await Navigation.PushModalAsync(lessonPage);
        }
    }
}
