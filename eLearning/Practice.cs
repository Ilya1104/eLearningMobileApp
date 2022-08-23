using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace eLearning
{    
    [Table("Practices")]
    public class Practice
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string ThirdImage { get; set; }
        public string FourthImage { get; set; }
        public string FifthImage { get; set; }
        public string SixthImage { get; set; }
        public string Task1 { get; set; }
        public string Task2 { get; set; }
        public string Task3 { get; set; }
        public string Preview { get; set; }

    }
}
