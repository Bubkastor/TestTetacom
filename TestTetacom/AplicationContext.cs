using Microsoft.EntityFrameworkCore;
using TestTetacom.Model;

namespace TestTetacom
{
    public class AplicationContext: DbContext
    {
        public DbSet<GroupedWellStatus> GroupedWellStatuses { get; set; }
        private readonly string connectionString;

        public AplicationContext(string connectionString)
        {
            Database.EnsureCreated();
            this.connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
