using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            HasKey(t => t.AccountId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Avatar)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(Account));
            Property(t => t.AccountId).HasColumnName("AccountId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.Avatar).HasColumnName("Avatar");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
