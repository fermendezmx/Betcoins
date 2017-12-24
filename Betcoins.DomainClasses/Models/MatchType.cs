using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class MatchType
    {
        public MatchType()
        {
            Matches = new HashSet<Match>();
        }

        public int MatchTypeId { get; set; }
        public string Type { get; set; }

        #region Relationships

        public ICollection<Match> Matches { get; set; }

        #endregion
    }
}
