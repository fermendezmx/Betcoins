using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class CompetitionMap : EntityTypeConfiguration<Competition>
    {
        public CompetitionMap()
        {
            // Primary Key
            HasKey(t => t.CompetitionId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable(nameof(Competition));
            Property(t => t.CompetitionId).HasColumnName("CompetitionId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
        }
    }
}
