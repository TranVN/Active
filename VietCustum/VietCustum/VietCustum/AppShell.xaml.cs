using System;
using System.Collections.Generic;
using VietCustum.ViewModels;
using VietCustum.Views;
using Xamarin.Forms;

namespace VietCustum
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
