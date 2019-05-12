using SemesterApp.Views.Subviews;
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
	public partial class Vejledning : ContentPage
	{
		public Vejledning ()
		{
			InitializeComponent ();
		}
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProgramDesc());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Excercise());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DiaryInfo());
        } /* test */
    }
}