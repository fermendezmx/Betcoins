using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class TeamCompetitionGroupMap : EntityTypeConfiguration<TeamCompetitionGroup>
    {
        public TeamCompetitionGroupMap()
        {
            // Primary Key
            HasKey(t => t.TeamCompetitionGroupId);

            // Properties
            Property(t => t.Points)
                .IsRequired();

            Property(t => t.Played)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            Property(t => t.Won)
                .IsRequired();

            Property(t => t.Lost)
                .IsRequired();

            Property(t => t.Draw)
                .IsRequired();

            Property(t => t.GoalFor)
                .IsRequired();

            Property(t => t.GoalAgainst)
                .IsRequired();

            Property(t => t.GoalDifference)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(TeamCompetitionGroup));
            Property(t => t.TeamCompetitionGroupId).HasColumnName("TeamCompetitionGroupId");
            Property(t => t.TeamCompetitionId).HasColumnName("TeamCompetitionId");
            Property(t => t.GroupId).HasColumnName("GroupId");
            Property(t => t.Points).HasColumnName("Points");
            Property(t => t.Played).HasColumnName("Played");
            Property(t => t.Won).HasColumnName("Won");
            Property(t => t.Lost).HasColumnName("Lost");
            Property(t => t.Draw).HasColumnName("Draw");
            Property(t => t.GoalFor).HasColumnName("GoalFor");
            Property(t => t.GoalAgainst).HasColumnName("GoalAgainst");
            Property(t => t.GoalDifference).HasColumnName("GoalDifference");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Team)
                .WithMany(t => t.Groups)
                .HasForeignKey(t => t.TeamCompetitionId);

            HasRequired(t => t.Group)
                .WithMany(t => t.Teams)
                .HasForeignKey(t => t.GroupId);
        }
    }
}
