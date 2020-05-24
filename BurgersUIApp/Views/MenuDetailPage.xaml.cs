using System;
using System.Collections.Generic;
using BurgersUIApp.ViewModels;
using Xamarin.Forms;

namespace BurgersUIApp.Views
{
    public partial class MenuDetailPage : ContentPage
    {
        public MenuDetailPage()
        {
            InitializeComponent();
            BindingContext = new MenuDetailsViewModel();
        }
    }
}
