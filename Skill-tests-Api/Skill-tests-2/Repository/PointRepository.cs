using Microsoft.EntityFrameworkCore;
using Skill_tests_2.Data;
using Skill_tests_2.Interface;
using Skill_tests_2.Models;

namespace Skill_tests_2.Repository
{
    public class PointRepository : IRepositoryPoint<Point>
    {
        private readonly DataContext _context;

        public PointRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Point> Create(Point entity)
        {
            try
            {
                _context.Points.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return entity;
        }

        public async Task<Point> Delete(int idEnity)
        {
            var point = await _context.Points.Include(c => c.Comments).Where(p => p.Id == idEnity).FirstOrDefaultAsync();

            if (point == null)
                return null;

            try
            {
                _context.Points.Remove(point);
                await _context.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            return point;
        }

        public async Task<List<Point>> GetAll()
        {
            return await _context.Points.Include(p => p.Comments).ToListAsync();
        }
    }
}
