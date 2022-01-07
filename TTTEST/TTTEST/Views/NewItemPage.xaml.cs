using System;
using System.Collections.Generic;
using System.ComponentModel;
using TTTEST.Models;
using TTTEST.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TTTEST.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}