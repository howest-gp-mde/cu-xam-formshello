using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace XrnCourse.FormsHello
{
    public partial class RandomNumberPage : ContentPage
    {
        Random rnd = new Random();
        bool pageVisible = false;
        int total = 0;

        public RandomNumberPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            pageVisible = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () => GenerateNumber());
        }
        protected override void OnDisappearing()
        {
            pageVisible = false;
            base.OnDisappearing();
        }

        private void btnClearTotal_Clicked(object sender, EventArgs e)
        {
            total = 0;
            lblTotal.Text = "-";
        }
        private bool GenerateNumber()
        {
            int number = rnd.Next(100);
            Debug.WriteLine($"Last Random Number: {number}");
            total += number;
            lblTotal.Text = total.ToString("N0");
            lblNumber.Text = number.ToString();
            return pageVisible; //true = repeat
        }

    }

}