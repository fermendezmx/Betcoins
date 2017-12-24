using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class StageMap : EntityTypeConfiguration<Stage>
    {
        public StageMap()
        {
            // Primary Key
            HasKey(t => t.StageId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable(nameof(Stage));
            Property(t => t.StageId).HasColumnName("StageId");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
