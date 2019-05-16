using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemesterApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Træningsdagbog2 : ContentPage
    {
        public Træningsdagbog2()
        {
            InitializeComponent();
        }
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Træningsdagbog3());
        }
    }
}