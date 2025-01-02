using Microsoft.EntityFrameworkCore;
using RRHI_Technical_Exam.Models;

namespace RRHI_Technical_Exam.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
