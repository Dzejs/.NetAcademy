namespace Library.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public DateTime MemberDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string MemberType { get; set; }
        public List<BorrowedBy> Books { get; set; }
    }
}
