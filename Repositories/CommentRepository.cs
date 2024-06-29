using api.Data;
using api.DTOs.Comment;
using api.Interfaces;
using api.Models;

namespace api.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task<Comment> CreateAsync(CreateCommentDto comment)
        {
            throw new NotImplementedException();
        }

        public Task<Comment?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Comment?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment?> UpdateAsync(int id, UpdateCommentDto comment)
        {
            throw new NotImplementedException();
        }
    }
}