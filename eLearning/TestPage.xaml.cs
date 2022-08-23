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
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }
        Dictionary<int, string> answers = new Dictionary<int, string>()
        {
            [0] = "Да",
            [1] = "Нет",
            [2] = "answer2",
            [3] = "answer3",
            [4] = "answer4",
            [5] = "answer5",
            [6] = "answer6",
            [7] = "answer7",
            [8] = "answer8",
            [9] = "answer9",
            [10] = "answer10",
            [11] = "answer11",
            [12] = "answer12",
            [13] = "answer13",
            [14] = "answer14"
        };
        RadioButton[] r = new RadioButton[4];
        string[] ss = new string[15] { "Вопрос 0", "Вопрос 1", "Вопрос 2", "Вопрос 3", "Вопрос 4", "Вопрос 5", "Вопрос 6", "Вопрос 7", "Вопрос 8", "Вопрос 9", "Вопрос 10", "Вопрос 11", "Вопрос 12", "Вопрос 13", "Вопрос 14" };
        int[] arr = new int[15];
        public int rightAnswers, questionCount;
        Random rnd = new Random();
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Test selectedTest = (Test)e.SelectedItem;
            SelectedTestPage testPage = new SelectedTestPage();
            testPage.BindingContext = selectedTest;
            await Navigation.PushModalAsync(testPage);
        }
        protected async override void OnAppearing()
        {
            await App.DatabaseTest.CreateTable();
            testsList.ItemsSource = await App.DatabaseTest.GetItemsAsync();
            base.OnAppearing();
       /*     r[0] = radio1;
            r[1] = radio2;
            r[2] = radio3;
            r[3] = radio4;
            rightAnswers = 0;
            questionCount = 0;
            mark.IsVisible = false;
            quesTable.IsVisible = true;
            gg();
            for (int i = 0; i < 10; i++)
            {
                testL.Text += (" " + arr[i]);
            }*/
        }/*
        private int[] radioIndex = new int[4];
        private int[] radio()
        {
            for (int i = 0; i < 4; i++)
            {
                radioIndex[i] = i+1;
            }
            for (int i = 0; i < 4; i++)
            {
                int b = rnd.Next(i);
                int c = radioIndex[i];
                radioIndex[i] = radioIndex[b];
                radioIndex[b] = c;
            }
            return radioIndex;
        }
        private void Get(object sender, EventArgs e) 
        {
            radio();
            if (questionCount < 10)
            {
                int n = arr[questionCount];
                questions.Text = ss[n];
                
                
                for(int i = 0; i < 4; i++)
                {
                    if (r[i].TabIndex == radioIndex[0])
                    {
                        r[i].Content = answers[n];
                    }
                }
             
                
                rightAnswers++;
                
                questionCount++;
            }
            else
            {
                mark.IsVisible = true;
                quesTable.IsVisible = false;
                mark.Text = rightAnswers.ToString();
            }
            
        }
        private int[] gg()
        {
            for(int i = 0; i<15; i++)
            {
                arr[i] = i;
            }
            for (int i = 0; i < 15; i++)
            {
                int b = rnd.Next(i);
                int c = arr[i];
                arr[i] = arr[b];
                arr[b] = c;
            }
            return arr;
        }*/
    }
}