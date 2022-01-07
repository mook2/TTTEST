using System;
using TTTEST.ViewModels;
using TTTEST.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTTEST.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReqNewPassword : ContentPage
    {
        public ReqNewPassword()
        {
            InitializeComponent();
            BindingContext = new ReqNewPasswordModel();
        }


        private void sdcLoginPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());

            //ApiService.apiService = new ApiService();44
        }

    }
}