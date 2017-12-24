using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class MatchMap : EntityTypeConfiguration<Match>
    {
        public MatchMap()
        {
            // Primary Key
            HasKey(t => t.MatchId);

            // Properties
            Property(t => t.Date)
                .IsRequired();

            Property(t => t.HomeTeamGoals)
                .IsRequired();

            Property(t => t.VisitorTeamGoals)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(Match));
            Property(t => t.MatchId).HasColumnName("MatchId");
            Property(t => t.HomeTeamId).HasColumnName("HomeTeamId");
            Property(t => t.VisitorTeamId).HasColumnName("VisitorTeamId");
            Property(t => t.StageId).HasColumnName("StageId");
            Property(t => t.CompetitionId).HasColumnName("CompetitionId");
            Property(t => t.TypeId).HasColumnName("TypeId");
            Property(t => t.Date).HasColumnName("Date");
            Property(t => t.HomeTeamGoals).HasColumnName("HomeTeamGoals");
            Property(t => t.VisitorTeamGoals).HasColumnName("VisitorTeamGoals");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .HasForeignKey(t => t.HomeTeamId);

            HasRequired(t => t.VisitorTeam)
                .WithMany(t => t.VisitorMatches)
                .HasForeignKey(t => t.VisitorTeamId);

            HasRequired(t => t.Stage)
                .WithMany(t => t.Matches)
                .HasForeignKey(t => t.StageId);

            HasRequired(t => t.Competition)
                .WithMany(t => t.Matches)
                .HasForeignKey(t => t.CompetitionId);

            HasRequired(t => t.Type)
                .WithMany(t => t.Matches)
                .HasForeignKey(t => t.TypeId);
        }
    }
}
