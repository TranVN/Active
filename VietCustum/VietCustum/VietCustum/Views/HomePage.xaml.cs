using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VietCustum.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public async void ChangePage_ThoDien(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThoDien());
        }
        public async void ChangePage_DienNuoc(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThoDienNuoc());
        }
        public async void ChangePage_DienLanh(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThoDienLanh());
        }
        public async void ChangePage_ChongTham(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThoChongTham());

        }
        public async void ChangePage_ThoMoc(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ThoMoc());
        }
        public void ChangePage_Khac(object sender, System.EventArgs e)
        {
            var modalPage = new DVKhacModalPage();
            App.Current.MainPage.Navigation.PushPopupAsync(modalPage, true);
        }
    }
}