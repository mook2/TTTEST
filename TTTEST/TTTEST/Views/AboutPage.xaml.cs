using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTTEST.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void sdcLogin_Clicked(object sender, EventArgs e)
        {

            try
            {
                DisplayAlert("아이디", entEmail.Text, "비밀번호", entPassword.Text);
            }
            catch (Exception exe)
            {
                DisplayAlert("오류", "값을 입력해주세요", "확인");
                return;
            }

            void sdcEventAdd()
            {
                sdcFindPassword.GestureRecognizers.Add(new TapGestureRecognizer()
                {
                    Command = new Command(() =>
                    {
                        Navigation.PushAsync(new ReqNewPassword());

                    })
                });

            }


        }
    }
}