namespace ThesisWorkBackend.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public ICollection<Resume> Resumes { get; set; }
    }
}
