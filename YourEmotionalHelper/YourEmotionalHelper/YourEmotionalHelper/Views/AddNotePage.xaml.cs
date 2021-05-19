using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourEmotionalHelper.Models;
using YourEmotionalHelper.Services;
using YourEmotionalHelper.Views;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace YourEmotionalHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNotePage : ContentPage
    {
        public List<Mood> Moods { get; set; }
        public List <Activity> Activities { get; set; }
        public List<Emotion> Emotions { get; set; }

        public AddNotePage()
        {
           
            InitializeComponent();
        }
        protected override void OnAppearing()

        {
            time.Time= DateTime.Now.TimeOfDay;
            date.Date = DateTime.Now.Date;
            Moods = App.database.GetMoodItems().ToList();
            Activities = App.database.GetActivityItems().ToList();
            Emotions = App.database.GetEmotionItems().ToList();
            MoodList.ItemsSource = App.database.GetMoodItems();
            EmotionList.ItemsSource = App.database.GetEmotionItems();
            ActivityList.ItemsSource = App.database.GetActivityItems();
            base.OnAppearing();
            Debug.WriteLine(App.database.GetMoodItems());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //add note
            //DayNote dn = new DayNote();
            //dn.emotions = new List<Emotion>();
            //dn.activities = new List<Activity>();
            //var selmood= (Mood)MoodList.SelectedItem;
            //dn.curMood = App.database.GetMoodItems().Where(mood => mood.Id == selmood.Id).FirstOrDefault();
            
      
            
            //List<Emotion> el = new List<Emotion>();

            //var emo = EmotionList.SelectedItems;
            //foreach (var i in emo)
            //{
            //    var k = (Emotion)i;              
            //    dn.emotions.Add(k);
            //}
          
            //foreach (var i in ActivityList.SelectedItems)
            //{
            //    var k = (Activity)i;
            //    dn.activities.Add((Activity)i);
            //}
            //dn.Soughts = notes.Text;
            
            //DateTime dt= new DateTime(date.Date.Year, date.Date.Month, date.Date.Day, time.Time.Hours, time.Time.Minutes, 0);
            //dn.NoteDate = dt;

            //App.database.SaveItem(dn);

            //var a = dn.activities.Count;
            //var ka = App.database.GetNotesItems();
            //foreach (DayNote day in ka)
            //{
            //    var act = day.activities;
            //    var mood = day.curMood.MoodName;
            //}
            await Navigation.PopModalAsync();


        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}