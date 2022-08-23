using SQLite;
using System;
using c = System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLearning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public int profileTestCount, sumMarks;
        double profileAvgMark;
        public ProfilePage()
        {
            InitializeComponent();
            
          //  L1.Text += Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "one.png");
        }
        protected string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), App.DATABASE_NAME);
        protected override async void OnAppearing()
        {
                if(profileTestCount == 0 && sumMarks == 0)
            {
                testCount.Text += 0;
                avgMark.Text += 0;
            }
            else
            {
                testCount.Text += profileTestCount;
                avgMark.Text += sumMarks / profileTestCount;
            }
                
            
            /*  RegistrationPage rp = new RegistrationPage();
              string query = $"select _id from Users where NickName='{rp.userNickName}';";
              c.SQLiteConnection con = new c.SQLiteConnection(dbPath);
              c.SQLiteCommand cmd = new c.SQLiteCommand(query, con);
              await App.DatabaseUser.GetItemAsync(int.Parse(cmd.ExecuteScalar().ToString()));
              base.OnAppearing();*/

        }
        async void GetPhotoAsync(object sender, EventArgs e)
        {
            try
            {
                // выбираем фото
                var photo = await MediaPicker.PickPhotoAsync();
                // загружаем в ImageView
                profileImage.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
            }
        }

    }

}