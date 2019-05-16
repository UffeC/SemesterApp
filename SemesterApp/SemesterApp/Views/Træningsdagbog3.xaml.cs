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
	public partial class Træningsdagbog3 : ContentPage
	{
		public Træningsdagbog3 ()
		{
			InitializeComponent ();
		}
        private void Gem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "All Vaues stored", "OK");
        }

        private async void btn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Træningsdagbog4());
        }
    }
}