namespace Library.Models
{
    public class PublishedBy
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Books { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
