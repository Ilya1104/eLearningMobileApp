﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace eLearning
{
    [Table("Tests")]
    public class Test
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Preview { get; set; }
    }
}
