using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace YourEmotionalHelper.Models
{
    public class NotesRepository
    {

        SQLiteConnection database;
        public NotesRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Mood>();
            database.CreateTable<Activity>();
            database.CreateTable<Emotion>();
            database.CreateTable<DayNote>();
            
        }
        public IEnumerable<DayNote> GetNotesItems()
        {
            return database.Table<DayNote>().ToList();
        }
        public DayNote GetItem(int id)
        {
            return database.Get<DayNote>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<DayNote>(id);
        }
        public int SaveItem(DayNote item)
        {
            if (item.NoteId != 0)
            {
                database.Update(item);
                return item.NoteId;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<Mood> GetMoodItems()
        {
            return database.Table<Mood>().ToList();
        }
        public Mood GetMoodItem(int id)
        {
            return database.Get<Mood>(id);
        }
     
        public int SaveMoodItem(Mood item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<Emotion> GetEmotionItems()
        {
            return database.Table<Emotion>().ToList();
        }
        public Emotion GetEmotionItem(int id)
        {
            return database.Get<Emotion>(id);
        }
        public int DeleteEmotionItem(int id)
        {
            return database.Delete<DayNote>(id);
        }
        public int SaveEmotionItem(Emotion item)
        {
            if (item.EmotionId != 0)
            {
                database.Update(item);
                return item.EmotionId;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<Activity> GetActivityItems()
        {
            return database.Table<Activity>().ToList();
        }
        public Activity GetActivityItem(int id)
        {
            return database.Get<Activity>(id);
        }
        public int DeleteActivityItem(int id)
        {
            return database.Delete<Activity>(id);
        }
        public int SaveActivityItem(Activity item)
        {
            if (item.ActivityId != 0)
            {
                database.Update(item);
                return item.ActivityId;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}

