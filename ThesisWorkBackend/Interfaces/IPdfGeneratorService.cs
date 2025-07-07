using ThesisWorkBackend.Models;

namespace ThesisWorkBackend.Interfaces
{
    public interface IPdfGeneratorService
    {
        Task<byte[]> GeneratePdfAsync(Resume resume, string templateName);
    }
}
