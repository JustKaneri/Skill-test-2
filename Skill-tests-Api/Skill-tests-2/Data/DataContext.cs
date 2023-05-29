using Microsoft.EntityFrameworkCore;
using Skill_tests_2.Models;

namespace Skill_tests_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<Point> Points { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
