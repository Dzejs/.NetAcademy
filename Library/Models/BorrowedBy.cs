namespace Library.Models
{
    public class BorrowedBy
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Issue { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
