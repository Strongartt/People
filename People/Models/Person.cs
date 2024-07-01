using SQLite;


namespace People.Models
{
    [Table("people")]

        public class Person
    {

        [PrimaryKey, AutoIncrement]

        public int Id  { get; set; }

        [MaxLength(250), Unique]

        public string Name { get; set; }

        [MaxLength(100)]
        public string Ciudad { get; set; }
}
}

