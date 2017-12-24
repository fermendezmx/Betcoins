using System;

namespace Betcoins.DomainClasses.Models
{
    public class AccountCompetition
    {
        public int AccountCompetitionId { get; set; }
        public int AccountId { get; set; }
        public int CompetitionId { get; set; }
        public int Coins { get; set; }
        public bool HasSecondChance { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public Account Account { get; set; }
        public Competition Competition { get; set; }

        #endregion
    }
}
