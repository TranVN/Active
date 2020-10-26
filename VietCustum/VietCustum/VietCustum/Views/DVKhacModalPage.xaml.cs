using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VietCustum.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DVKhacModalPage : PopupPage
    {
        public DVKhacModalPage()
        {
            InitializeComponent();
            //App.Current.MainPage.Navigation.PopPopupAsync(true);
        }
        public async void ChangePage_ThoDien(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThoDien());
            await Navigation.PopPopupAsync(true);
        }
    }
}