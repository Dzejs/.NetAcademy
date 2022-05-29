namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; }
        public List<PublishedBy> Publishers { get; set; }
        public List<BorrowedBy> Members { get; set; }
    }
}
