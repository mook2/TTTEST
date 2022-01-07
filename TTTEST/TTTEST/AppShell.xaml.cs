

using System;
using System.Collections.Generic;
using TTTEST.ViewModels;
using TTTEST.Views;
using Xamarin.Forms;

namespace TTTEST
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(ReqNewPassword), typeof(ReqNewPassword));
        }

    }
}
