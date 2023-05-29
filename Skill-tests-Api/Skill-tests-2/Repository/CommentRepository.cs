using Microsoft.EntityFrameworkCore;
using Skill_tests_2.Data;
using Skill_tests_2.Interface;
using Skill_tests_2.Models;

namespace Skill_tests_2.Repository
{
    public class CommentRepository : IRepositoryComment<Comment>
    {
        private readonly DataContext _context;

        public CommentRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Comment> Create(Comment enity)
        {
            if (_context.Points.Find(enity.PointId) == null)
            {
                return null;
            }


            try
            {
                _context.Comments.Add(enity);
                await _context.SaveChangesAsync();
            }
            catch 
            {
                return null;
            }

            return enity;
        }

        public async Task<Comment> Delete(int id)
        {
            Comment comment = await _context.Comments.FindAsync(id);

            try
            {
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return comment;
        }

        public async Task<List<Comment>> GetCommentCurrentPoint(int idPoint)
        {
            return await _context.Comments.Include(p => p.Point).Where(c => c.PointId == idPoint).ToListAsync();
        }
    }
}
