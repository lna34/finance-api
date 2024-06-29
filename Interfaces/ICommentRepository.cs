using api.DTOs.Comment;
using api.Models;

namespace api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(CreateCommentDto comment);
        Task<Comment?> UpdateAsync(int id, UpdateCommentDto comment);
        Task<Comment?> DeleteAsync(int id);
    }
}