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
            Property(t => t.Email)
                .IsRequired();

            Property(t => t.FirstName)
                .IsRequired();

            Property(t => t.LastName)
                .IsRequired();

            Property(t => t.NickName)
                .IsRequired();

            Property(t => t.Picture)
                .IsRequired();

            // Table & Column Mappings
            ToTable(nameof(Account));
            Property(t => t.AccountId).HasColumnName("AccountId");
            Property(t => t.Email).HasColumnName("Email");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.LastName).HasColumnName("LastName");
            Property(t => t.NickName).HasColumnName("NickName");
            Property(t => t.Picture).HasColumnName("Picture");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
