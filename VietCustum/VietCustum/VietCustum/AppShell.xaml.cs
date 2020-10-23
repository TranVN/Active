using System;
using System.Collections.Generic;
using VietCustum.ViewModels;
using VietCustum.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VietCustum
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
        }
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("//LoginPage");
        }
       private async void Home_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
        private async void ButtonFabcon_Clicked(object sender, System.EventArgs e)
        {
            //await ((ImageButton)sender).ScaleTo(0.8, 50, Easing.Linear);
            //await Task.Delay(100);
            await Launcher.OpenAsync(new Uri("tel:0903532938"));
            //await ((ImageButton)sender).ScaleTo(1, 50, Easing.Linear);
        }

        
    }

    
}
