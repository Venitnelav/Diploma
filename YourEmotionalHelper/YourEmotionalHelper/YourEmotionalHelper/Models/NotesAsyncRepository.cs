using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YourEmotionalHelper.Models
{
    public class NotesAsyncRepository
    {
        SQLiteAsyncConnection database;

        public NotesAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTables()
        {
            await database.CreateTableAsync<Mood>();
            await database.CreateTableAsync<Emotion>();
            await database.CreateTableAsync<Activity>();
            await database.CreateTableAsync<DayNote>();
        }
        public async Task<List<DayNote>> GetItemsNotesAsync()
        {
            return await database.Table<DayNote>().ToListAsync();

        }
        public async Task<DayNote> GetItemNoteAsync(int id)
        {
            return await database.GetAsync<DayNote>(id);
        }
        public async Task<int> DeleteItemAsync(DayNote item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(DayNote item)
        {
            if (item.NoteId != 0)
            {
                await database.UpdateAsync(item);
                return item.NoteId;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        public async Task<List<Mood>> GetItemsMoodAsync()
        {
            return await database.Table<Mood>().ToListAsync();

        }
        public async Task<Mood> GetItemMoodAsync(int id)
        {
            return await database.GetAsync<Mood>(id);
        }
        public async Task<int> DeleteItemMoodAsync(Mood item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemMoodAsync(Mood item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        public async Task<List<Activity>> GetItemsActivityAsync()
        {
            return await database.Table<Activity>().ToListAsync();

        }
        public async Task<Activity> GetItemActivityAsync(int id)
        {
            return await database.GetAsync<Activity>(id);
        }
        public async Task<int> DeleteItemActivityAsync(Activity item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemActivityAsync(Activity item)
        {
            if (item.ActivityId != 0)
            {
                await database.UpdateAsync(item);
                return item.ActivityId;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        public async Task<List<Emotion>> GetItemsEmotionAsync()
        {
            return await database.Table<Emotion>().ToListAsync();

        }
        public async Task<Emotion> GetItemEmotionAsync(int id)
        {
            return await database.GetAsync<Emotion>(id);
        }
        public async Task<int> DeleteItemEmotionAsync(Emotion item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemEmotionAsync(Emotion item)
        {
            if (item.EmotionId != 0)
            {
                await database.UpdateAsync(item);
                return item.EmotionId;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
    
}
