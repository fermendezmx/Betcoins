using System.Data.Entity.ModelConfiguration;

namespace Betcoins.DomainClasses.Models.Mapping
{
    public class GroupMap : EntityTypeConfiguration<Group>
    {
        public GroupMap()
        {
            // Primary Key
            HasKey(t => t.GroupId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            ToTable(nameof(Group));
            Property(t => t.GroupId).HasColumnName("GroupId");
            Property(t => t.Name).HasColumnName("Name");
        }
    }
}
