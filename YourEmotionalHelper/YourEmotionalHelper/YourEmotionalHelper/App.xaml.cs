using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YourEmotionalHelper.Models;
using YourEmotionalHelper.Services;
using YourEmotionalHelper.Views;
using System.Linq;
using Android.Content.Res;

namespace YourEmotionalHelper
{
    public partial class App : Application
    {
        public interface INotificationManager
        {
            event EventHandler NotificationReceived;
            void Initialize();
            void SendNotification(string title, string message, DateTime? notifyTime = null);
            void ReceiveNotification(string title, string message);
        }
        public class NotificationEventArgs : EventArgs
        {
            public string Title { get; set; }
            public string Message { get; set; }
        }
        public const string DATABASE_NAME = "NotesDB.db";
        public static NotesRepository database;
        public static NotesRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new NotesRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        //public const string DATABASE_NAME = "notes.db";
        //public static NotesAsyncRepository database;
        //public static NotesAsyncRepository Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new NotesAsyncRepository(
        //                Path.Combine(
        //                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
        //        }
        //        return database;
        //    }
        //}
        public App()
        {
            InitializeComponent();
            if (database == null)
            {
                database = new NotesRepository(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
                //if (database == null)
                //{
                //    database = new NotesAsyncRepository(
                //        Path.Combine(
                //            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));                
                //}
                
            FillDB();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public void FillDB()
        {
            if (database.GetMoodItems().Count()==0)
            {
                Mood mood5 = new Mood();
                mood5.MoodName = "Жахливо";
                mood5.ImagePath = "awful.png";
                mood5.MoodColor = " ";
                database.SaveMoodItem(mood5);
                Mood mood4 = new Mood();
                mood4.MoodName = "Погано";
                mood4.ImagePath = "bad.png";
                mood4.MoodColor = " ";
                database.SaveMoodItem(mood4);
                Mood mood3 = new Mood();
                mood3.MoodName = "Нормально";
                mood3.ImagePath = "normal.png";
                mood3.MoodColor = " ";
                database.SaveMoodItem(mood3);
                Mood mood2 = new Mood();
                mood2.MoodName = "Добре";
                mood2.ImagePath = "good.png";
                mood2.MoodColor = " ";
                database.SaveMoodItem(mood2);
                Mood mood1 = new Mood();
                mood1.MoodName = "Чудово";
                mood1.ImagePath = "awsome.png";
                mood1.MoodColor = " ";
                database.SaveMoodItem(mood1);


            }
            if (database.GetEmotionItems().Count() == 0)
            {
                Emotion emo1 = new Emotion();
                emo1.EmotionName = "Радість";
                emo1.PosNegIndex = 1;
                database.SaveEmotionItem(emo1);
                Emotion emo2 = new Emotion();
                emo2.EmotionName = "Натхнення";
                emo2.PosNegIndex = 1;
                database.SaveEmotionItem(emo2);
                Emotion emo3 = new Emotion();
                emo3.EmotionName = "Задоволення";
                emo3.PosNegIndex = 1;
                database.SaveEmotionItem(emo3);
                Emotion emo4 = new Emotion();
                emo4.EmotionName = "Любов";
                emo4.PosNegIndex = 1;
                database.SaveEmotionItem(emo4);
                Emotion emo5 = new Emotion();
                emo5.EmotionName = "Упевненість";
                emo5.PosNegIndex = 1;
                database.SaveEmotionItem(emo5);
                Emotion emo6 = new Emotion();
                emo6.EmotionName = "Роздратування";
                emo6.PosNegIndex = 0;
                database.SaveEmotionItem(emo6);
                Emotion emo7 = new Emotion();
                emo7.EmotionName = "Стрес";
                emo7.PosNegIndex = 0;
                database.SaveEmotionItem(emo7);
                Emotion emo8 = new Emotion();
                emo8.EmotionName = "Тривога";
                emo8.PosNegIndex = 0;
                database.SaveEmotionItem(emo8);
                Emotion emo9 = new Emotion();
                emo9.EmotionName = "Сором";
                emo9.PosNegIndex = 0;
                database.SaveEmotionItem(emo9);
                Emotion emo10 = new Emotion();
                emo10.EmotionName = "Злість";
                emo10.PosNegIndex = 0;
                database.SaveEmotionItem(emo10);
                Emotion emo11 = new Emotion();
                emo11.EmotionName = "Страх";
                emo11.PosNegIndex = 0;
                database.SaveEmotionItem(emo11);

            }
            if (database.GetActivityItems().Count() == 0)
            { 
                Activity a1 = new Activity();
                a1.ActivityName = "Робота";             
                database.SaveActivityItem(a1);
                Activity a2 = new Activity();
                a2.ActivityName = "Навчання";
                database.SaveActivityItem(a2);
                Activity a3 = new Activity();
                a3.ActivityName = "Медитація";
                database.SaveActivityItem(a3);
                Activity a4 = new Activity();
                a4.ActivityName = "Йога";
                database.SaveActivityItem(a4);
                Activity a5 = new Activity();
                a5.ActivityName = "Прогулянка";
                database.SaveActivityItem(a5);
                Activity a6 = new Activity();
                a6.ActivityName = "Зустріч з друзями";
                database.SaveActivityItem(a6);

            }
            return;
        }

      

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
