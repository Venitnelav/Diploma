using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourEmotionalHelper.Models;
using YourEmotionalHelper.ViewModels;
using YourEmotionalHelper.Views;

namespace YourEmotionalHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityItems : ContentPage
    {
        ItemsViewModel _viewModel;
        public ActivityItems()
        {
            BindingContext = _viewModel = new ItemsViewModel();
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}