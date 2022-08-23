using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLearning
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string PhotoPath { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
