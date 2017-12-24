using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class League
    {
        public League()
        {
            Teams = new HashSet<Team>();
        }

        public int LeagueId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        #region Relationships

        public ICollection<Team> Teams { get; set; }

        #endregion
    }
}
