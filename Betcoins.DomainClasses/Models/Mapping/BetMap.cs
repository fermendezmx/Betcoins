using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class BetMap : EntityTypeConfiguration<Bet>
    {
        public BetMap()
        {
            // Primary Key
            HasKey(t => t.BetId);

            // Properties
            Property(t => t.Coins)
                .IsRequired();

            Property(t => t.HomeTeamGoals)
                .IsRequired();

            Property(t => t.VisitorTeamGoals)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(Bet));
            Property(t => t.BetId).HasColumnName("BetId");
            Property(t => t.AccountId).HasColumnName("AccountId");
            Property(t => t.MatchId).HasColumnName("MatchId");
            Property(t => t.Coins).HasColumnName("Coins");
            Property(t => t.HomeTeamGoals).HasColumnName("HomeTeamGoals");
            Property(t => t.VisitorTeamGoals).HasColumnName("VisitorTeamGoals");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Account)
                .WithMany(t => t.Bets)
                .HasForeignKey(t => t.AccountId);

            HasRequired(t => t.Match)
                .WithMany(t => t.Bets)
                .HasForeignKey(t => t.MatchId);
        }
    }
}
