using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace YourEmotionalHelper.Models
{
    public  class Mood 
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string MoodName { get; set; }
        public string MoodColor { get; set; }
        public string ImagePath{ get; set; }

}
}
