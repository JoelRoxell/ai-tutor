using Microsoft.EntityFrameworkCore;
using ai_tutor.Models;

namespace ai_tutor.Persistance
{
    public class AiTutorContext : DbContext
    {
        public AiTutorContext(DbContextOptions<AiTutorContext> connectionString): base(connectionString)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}