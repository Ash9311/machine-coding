namespace TaskManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Project> Project { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
