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
    public partial class PracticePage : ContentPage
    {
        public PracticePage()
        {
            InitializeComponent();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Practice selectedPractice = (Practice)e.SelectedItem;
            SelectedPracticePage practicePage = new SelectedPracticePage();
            practicePage.BindingContext = selectedPractice;
            await Navigation.PushModalAsync(practicePage);
        }
        protected async override void OnAppearing()
        {
            await App.PracticeDatabase.CreateTable();
            practiceList.ItemsSource = await App.PracticeDatabase.GetItemsAsync();
            base.OnAppearing();
        }
    }
}