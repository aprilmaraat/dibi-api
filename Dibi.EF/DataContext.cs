using Microsoft.EntityFrameworkCore;
using Dibi.Auth.Models;

namespace Dibi.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public virtual DbSet<AccountStatus> AccountStatus { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<UserData> UserData { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.EnableSensitiveDataLogging(false);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}