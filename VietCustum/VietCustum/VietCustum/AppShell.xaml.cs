using System;
using System.Collections.Generic;
using VietCustum.ViewModels;
using VietCustum.Views;
using Xamarin.Forms;

namespace VietCustum
{
    public partial class AppShell : Xamarin.Forms.TabbedPage
    {
        public AppShell()
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext(); // First page
            pages.MoveNext(); // Second page
            CurrentPage = pages.Current;
        }

    }
}
