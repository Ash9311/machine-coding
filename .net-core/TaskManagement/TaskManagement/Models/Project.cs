namespace TaskManagement.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public ICollection<Task> Tasks  { get; set; }
    }
}
