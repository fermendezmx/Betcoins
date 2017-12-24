using System;
using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class TeamCompetition
    {
        public TeamCompetition()
        {
            Groups = new HashSet<TeamCompetitionGroup>();
        }

        public int TeamCompetitionId { get; set; }
        public int TeamId { get; set; }
        public int CompetitionId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public Competition Competition { get; set; }
        public Team Team { get; set; }
        public ICollection<TeamCompetitionGroup> Groups { get; set; }

        #endregion
    }
}
