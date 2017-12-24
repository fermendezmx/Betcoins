using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class Stage
    {
        public Stage()
        {
            Matches = new HashSet<Match>();
        }

        public int StageId { get; set; }
        public string Name { get; set; }

        #region Relationships

        public ICollection<Match> Matches { get; set; }

        #endregion
    }
}
