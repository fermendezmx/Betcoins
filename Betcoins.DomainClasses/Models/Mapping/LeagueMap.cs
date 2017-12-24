using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class LeagueMap : EntityTypeConfiguration<League>
    {
        public LeagueMap()
        {
            // Primary Key
            HasKey(t => t.LeagueId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Logo)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(League));
            Property(t => t.LeagueId).HasColumnName("LeagueId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Logo).HasColumnName("Logo");
        }
    }
}
