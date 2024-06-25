namespace TaskManagement.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
