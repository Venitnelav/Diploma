using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace YourEmotionalHelper.Models
{
    public  class DayNote
    {
        [PrimaryKey, AutoIncrement]
        public int NoteId { get; set; }

        public int curMood;
        public List<Emotion> emotions;
        public List<Activity> activities;
        public string Soughts { get; set; }
        public string SituationNotes { get; set; }
        public DateTime NoteDate { get; set; }
        
        
    }
}
