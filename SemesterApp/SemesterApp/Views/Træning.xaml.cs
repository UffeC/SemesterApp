﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SemesterApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Træning : ContentPage
	{
		public Træning ()
		{
			InitializeComponent();
		}
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Træningsdagbog());
        }
    }
}