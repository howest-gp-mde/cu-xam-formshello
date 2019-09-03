using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Application.Current.ModalPopped += OnModalPopped;

            var msgService = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "Hello, " + msgService.GetWelcomeMessage();
        }
        private async void OnModalPopped(object sender, ModalPoppedEventArgs e)
        {
            if (e.Modal is ModalPage)
                await DisplayAlert("Modal Result",
                    $"You entered {(e.Modal as ModalPage).NameEntered}", "I know!");
        }

        private async void BtnAlertPage_Clicked(object sender, EventArgs e)
        {
            //navigate to AlertPage
            await Navigation.PushAsync(new AlertPage());
        }

        private async void BtnActionSheet_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: What to do?",
                "Cancel", null, "Show me the time", "Tell a joke", "Wait 3 seconds");

            if (action == "Show me the time")
            { 
                await DisplayAlert("Time",
                        $"It's now {DateTime.Now.ToString("HH:mm")}, almost beer-o-clock!", "OK");
            }
            else if (action == "Tell a joke")
            {
                await DisplayAlert("Joke",
                        $"Why is six afraid of seven?{Environment.NewLine}Because seven ate nine.",
                        "LOL", "I don't get it");
            }
            else if (action == "Wait 3 seconds")
            {
                await Task.Delay(3000);
                await DisplayAlert("Wait 3 seconds", "The wait is over.", "Ok");
            }
        }

        private async void BtnShowModal_Clicked(object sender, EventArgs e)
        {
            //display ModalPage
            var modalPage = new ModalPage();
            await Navigation.PushModalAsync(modalPage, true);
        }

        private async void BtnRandomNumber_Clicked(object sender, EventArgs e)
        {
            //display RandomNumberPage
            var modalPage = new RandomNumberPage();
            await Navigation.PushAsync(modalPage, true);
        }
    }
}
