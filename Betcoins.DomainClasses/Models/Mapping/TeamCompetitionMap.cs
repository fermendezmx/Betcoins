using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class TeamCompetitionMap : EntityTypeConfiguration<TeamCompetition>
    {
        public TeamCompetitionMap()
        {
            // Primary Key
            HasKey(t => t.TeamCompetitionId);

            // Properties
            Property(t => t.IsActive)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(TeamCompetition));
            Property(t => t.TeamCompetitionId).HasColumnName("TeamCompetitionId");
            Property(t => t.TeamId).HasColumnName("TeamId");
            Property(t => t.CompetitionId).HasColumnName("CompetitionId");
            Property(t => t.IsActive).HasColumnName("IsActive");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Team)
                .WithMany(t => t.Competitions)
                .HasForeignKey(t => t.TeamId);

            HasRequired(t => t.Competition)
                .WithMany(t => t.Teams)
                .HasForeignKey(t => t.CompetitionId);
        }
    }
}
