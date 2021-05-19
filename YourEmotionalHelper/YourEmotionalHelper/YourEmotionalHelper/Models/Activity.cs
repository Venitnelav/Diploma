using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace YourEmotionalHelper.Models
{
    public class Activity
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public int PosNegIndex { get; set; }
    }
}
