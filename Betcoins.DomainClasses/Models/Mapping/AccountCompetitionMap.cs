using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class AccountCompetitionMap : EntityTypeConfiguration<AccountCompetition>
    {
        public AccountCompetitionMap()
        {
            // Primary Key
            HasKey(t => t.AccountCompetitionId);

            // Properties
            Property(t => t.Coins)
                .IsRequired();

            Property(t => t.HasSecondChance)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(AccountCompetition));
            Property(t => t.AccountCompetitionId).HasColumnName("AccountCompetitionId");
            Property(t => t.AccountId).HasColumnName("AccountId");
            Property(t => t.CompetitionId).HasColumnName("CompetitionId");
            Property(t => t.Coins).HasColumnName("Coins");
            Property(t => t.HasSecondChance).HasColumnName("HasSecondChance");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            HasRequired(t => t.Account)
                .WithMany(t => t.Competitions)
                .HasForeignKey(t => t.AccountId);

            HasRequired(t => t.Competition)
                .WithMany(t => t.Accounts)
                .HasForeignKey(t => t.CompetitionId);
        }
    }
}
