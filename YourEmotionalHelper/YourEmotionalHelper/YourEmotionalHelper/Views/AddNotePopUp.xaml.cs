using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourEmotionalHelper.Models;
using System.IO;
using YourEmotionalHelper.Services;
using YourEmotionalHelper.Views;
using YourEmotionalHelper;


namespace YourEmotionalHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNote : PopupPage
    {
        

       
        public AddNote()
        {

            MoodList.ItemsSource = App.database.GetMoodItems();
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}