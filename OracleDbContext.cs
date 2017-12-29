using System.Data.Entity;
using System.Reflection;

namespace EntityOracleSample
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext()
            : base("cnString")
        {
            Database.SetInitializer<OracleDbContext>(null);
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ENTITYORACLE");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
