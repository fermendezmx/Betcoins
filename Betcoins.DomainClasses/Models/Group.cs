using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class Group
    {
        public Group()
        {
            Teams = new HashSet<TeamCompetitionGroup>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }

        #region Relationships

        public ICollection<TeamCompetitionGroup> Teams { get; set; }

        #endregion
    }
}
