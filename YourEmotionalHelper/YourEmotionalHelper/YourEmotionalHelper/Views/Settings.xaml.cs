using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YourEmotionalHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            Notification();
            CrossLocalNotifications.Current.Show("Friendly reminder", "Як у тебе справи? ", 0, DateTime.Now.AddSeconds(30));
        }

        private async void Notification()
        {
            int i = 0;
            if(notification.On==true)
            CrossLocalNotifications.Current.Show("Friendly reminder", "Як у тебе справи? ", 0, DateTime.Now.AddSeconds(5));

            
        }

        private async void LabelCell_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ActivityItems());
        }
    }
}