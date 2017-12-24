using System;

namespace Betcoins.DomainClasses.Models
{
    public class Bet
    {
        public int BetId { get; set; }
        public int AccountId { get; set; }
        public int MatchId { get; set; }
        public int Coins { get; set; }
        public int HomeTeamGoals { get; set; }
        public int VisitorTeamGoals { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public Account Account { get; set; }
        public Match Match { get; set; }

        #endregion
    }
}
