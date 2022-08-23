using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace eLearning
{
    [Table("Lessons")]
    public class Lesson
    {
        [PrimaryKey,AutoIncrement,Column("_id")]
        public int ID { get; set; }
        public string Theme { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string Description { get; set; }
        public string Preview { get; set; }

        public string Video { get; set; }
    }
}
