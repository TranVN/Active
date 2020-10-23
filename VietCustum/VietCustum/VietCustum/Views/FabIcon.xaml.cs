using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VietCustum.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FabIcon : ContentPage
    {
        public FabIcon()
        {
            InitializeComponent();
        }
        private async void ButtonFabcon_Clicked(object sender, System.EventArgs e)
        {
            await ((ImageButton)sender).ScaleTo(0.8, 50, Easing.Linear);
            await Task.Delay(100);
            await Launcher.OpenAsync(new Uri("tel:0903532938"));
            await ((ImageButton)sender).ScaleTo(1, 50, Easing.Linear);
        }
    }

    
}