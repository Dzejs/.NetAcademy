namespace Library.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public List<PublishedBy> Books { get; set; }
    }
}
