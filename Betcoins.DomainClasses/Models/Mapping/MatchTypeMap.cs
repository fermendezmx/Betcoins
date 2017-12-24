using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class MatchTypeMap : EntityTypeConfiguration<MatchType>
    {
        public MatchTypeMap()
        {
            // Primary Key
            HasKey(t => t.MatchTypeId);

            // Properties
            Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable(nameof(MatchType));
            Property(t => t.MatchTypeId).HasColumnName("MatchTypeId");
            Property(t => t.Type).HasColumnName("Type");
        }
    }
}
