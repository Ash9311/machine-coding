namespace Library_Management.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
    }
}
