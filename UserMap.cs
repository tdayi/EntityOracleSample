using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EntityOracleSample
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("User");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnOrder(1).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Name).IsRequired().HasMaxLength(50);
            this.Property(x => x.Surname).IsRequired().HasMaxLength(50);
        }
    }
}
