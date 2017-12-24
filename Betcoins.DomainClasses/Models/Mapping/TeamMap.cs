using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class TeamMap : EntityTypeConfiguration<Team>
    {
        public TeamMap()
        {
            // Primary Key
            HasKey(t => t.TeamId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(35);

            Property(t => t.Emblem)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(Team));
            Property(t => t.TeamId).HasColumnName("TeamId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Emblem).HasColumnName("Emblem");
            Property(t => t.LeagueId).HasColumnName("LeagueId");

            // Relationships
            HasRequired(t => t.League)
                .WithMany(t => t.Teams)
                .HasForeignKey(t => t.LeagueId);
        }
    }
}
