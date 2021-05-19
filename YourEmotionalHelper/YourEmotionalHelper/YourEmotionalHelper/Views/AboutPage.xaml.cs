using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourEmotionalHelper.Models;

namespace YourEmotionalHelper.Views
{
    public partial class AboutPage : ContentPage
    {
        public class DN
        {           
           public int NoteId { get; set; }

           public string moodName { get; set; }
           public string moodPath { get; set; }
           public string emo { get; set; }

           public string act  { get; set; }

           public string soughts { get; set; }
            
                public DateTime NoteDate { get; set; }


            }
        

        public List<DN> dayNotes = new List<DN>();
        public AboutPage()
        {
           // MoodList.ItemsSource = App.database.GetMoodItems();          
            InitializeComponent();
        }
        protected override  void OnAppearing()
        {
            // MoodList.ItemsSource = App.database.GetMoodItems();
            // EmotionList.ItemsSource = App.database.GetEmotionItems();
           // var note = App.database.GetNotesItems().Where(dn => dn.NoteDate.Date == DateTime.Now.Date ).ToList();
           // foreach (DayNote dnote in note)
           // {
           //     DN d = new DN();
           //     d.NoteId = dnote.NoteId;
           ////     Mood ak = dnote.curMood;
           ////    d.moodName = ak.MoodName;
           //  //  d.moodPath = ak.ImagePath;
           // //    d.soughts = dnote.Soughts;
           //     //d.act = "";
           //     foreach (Activity a in dnote.activities)
           //     {

           //         d.act +=  a.ActivityName;
           //         d.act += " ";
           //     }
           //     foreach (Emotion e in dnote.emotions)
           //     {

           //         d.act += e.EmotionName;
           //         d.act += " ";
           //     }
           //     dayNotes.Add(d);
           // }
            
           // //List.ItemsSource = note;
           // nList.ItemsSource = dayNotes;
           
               base.OnAppearing();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new AddNotePage());
            
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CalendarPage());
        }
    }
}

 //< ContentPage.Resources >
 //       < ResourceDictionary >
 //           < Color x: Key = "Accent" >#96d1ff</Color>
 //       </ ResourceDictionary >
  
 //     </ ContentPage.Resources >