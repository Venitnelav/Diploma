using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace YourEmotionalHelper.Models
{
    public  class Emotion
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int EmotionId { get; set; }
        public string EmotionName { get; set; }
        public int PosNegIndex { get; set; }

        
    }
}
