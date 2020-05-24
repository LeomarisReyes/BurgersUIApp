using System;
using System.Collections.Generic;
using BurgersUIApp.ViewModels;
using Xamarin.Forms;

namespace BurgersUIApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }
    }
}
