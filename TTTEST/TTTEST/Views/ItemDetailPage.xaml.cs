using System.ComponentModel;
using TTTEST.ViewModels;
using Xamarin.Forms;

namespace TTTEST.Views
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