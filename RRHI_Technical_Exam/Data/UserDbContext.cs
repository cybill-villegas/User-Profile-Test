using Microsoft.EntityFrameworkCore;
using RRHI_Technical_Exam.Models;

namespace RRHI_Technical_Exam.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETDATE()") // Set default value for SQL Server
                .ValueGeneratedOnAdd();
        }
    }


}
