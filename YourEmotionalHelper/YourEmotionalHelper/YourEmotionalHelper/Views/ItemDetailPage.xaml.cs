using System.ComponentModel;
using Xamarin.Forms;
using YourEmotionalHelper.ViewModels;

namespace YourEmotionalHelper.Views
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