namespace ThesisWorkBackend.Models
{
    public class Resume
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public PersonalInfo PersonalInfo { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
