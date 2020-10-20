using System.ComponentModel;
using Xamarin.Forms;
using VietCustum.ViewModels;

namespace VietCustum.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}