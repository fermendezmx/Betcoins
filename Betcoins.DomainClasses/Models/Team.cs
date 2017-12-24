using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class Team
    {
        public Team()
        {
            HomeMatches = new HashSet<Match>();
            VisitorMatches = new HashSet<Match>();
            Competitions = new HashSet<TeamCompetition>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Emblem { get; set; }
        public int LeagueId { get; set; }

        #region Relationships

        public League League { get; set; }
        public ICollection<Match> HomeMatches { get; set; }
        public ICollection<Match> VisitorMatches { get; set; }
        public ICollection<TeamCompetition> Competitions { get; set; }

        #endregion
    }
}
