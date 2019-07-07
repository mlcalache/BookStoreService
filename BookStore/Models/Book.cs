using System.Collections.Generic;

namespace BookStore.Models
{
    public class Book : BaseEntity
    {
        public List<Author> Author { get; set; }
        public BookTypeEnum BookType { get; set; }
        public Category Category { get; set; }
        public int Edition { get; set; }
        public int ISBN { get; set; }
        public string Location { get; set; }
        public int Name { get; set; }
        public Publisher Publisher { get; set; }
        public SizeEnum Size { get; set; }
        public int Year { get; set; }
    }
}