using ThesisWorkBackend.Models;

namespace ThesisWorkBackend.Interfaces
{
    public interface IResumeService
    {
        Task<Resume> CreateResumeAsync(Guid userId, Resume resume);
        Task<Resume> GetResumeAsync(Guid id);
        Task<IEnumerable<Resume>> GetResumesByUserAsync(Guid userId);
        Task<Resume> UpdateResumeAsync(Resume resume);
        Task DeleteResumeAsync(Guid id);
    }
}
