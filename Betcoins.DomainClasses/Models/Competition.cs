using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class Competition
    {
        public Competition()
        {
            Accounts = new HashSet<AccountCompetition>();
            Matches = new HashSet<Match>();
            Teams = new HashSet<TeamCompetition>();
        }

        public int CompetitionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Relationships

        public ICollection<AccountCompetition> Accounts { get; set; }
        public ICollection<Match> Matches { get; set; }
        public ICollection<TeamCompetition> Teams { get; set; }

        #endregion
    }
}
