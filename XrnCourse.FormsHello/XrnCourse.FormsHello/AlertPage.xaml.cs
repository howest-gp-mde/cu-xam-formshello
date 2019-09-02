using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.FormsHello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertPage : ContentPage
    {
        public AlertPage()
        {
            InitializeComponent();
        }

        private async void BtnPopupHello_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Hello there!", "Hi!");
        }

        private async void BtnGoBack_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Goin' back", "Wanna go back?", "Yep", "No, wait!"))
                await Navigation.PopAsync(true);
        }
    }
}