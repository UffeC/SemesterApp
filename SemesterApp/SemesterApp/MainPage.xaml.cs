using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemesterApp.Views;
using SemesterApp.Data;
using Xamarin.Forms;

namespace SemesterApp
{
    public partial class MainPage : ContentPage
    {
        private LoginManager loginManager = new LoginManager();
        private readonly AuthorizationManager authorizationManager = new AuthorizationManager();
        private readonly UserManager userManager = new UserManager();

        private LoginContent _loginContent;
        public LoginContent LoginContent
        {
            get
            {
                return _loginContent;
            }
            set
            {
                _loginContent = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        async protected override void OnAppearing()
        {
            LoginContent = await loginManager.GetContent();

            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Get authorization status from entry
            bool authorizationStatus = await authorizationManager.Authorize(LoginEntry.Text);

            bool creationStatus = false;

            // Display alerts
            if (authorizationStatus)
            {
                creationStatus = await userManager.Create(LoginEntry.Text);
                await DisplayAlert("Success", "Your user has been found in RedCap", "OK");
            }
            else
            {
                await DisplayAlert("Warning", "You are unauthorized", "OK");
            }

            // Display alerts
            if (creationStatus)
            {
                await DisplayAlert("Success", "User created. You have logged in", "OK");
                await Navigation.PushAsync(new intro());
            }
            else
            {
                await DisplayAlert("Warning", "User creation failed", "OK");
            }
        }
    }
}
