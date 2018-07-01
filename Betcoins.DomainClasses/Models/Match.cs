using System;
using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class Match
    {
        public Match()
        {
            Bets = new HashSet<Bet>();
        }

        public int MatchId { get; set; }
        public int HomeTeamId { get; set; }
        public int VisitorTeamId { get; set; }
        public int StageId { get; set; }
        public int CompetitionId { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public int HomeTeamGoals { get; set; }
        public int VisitorTeamGoals { get; set; }
        public bool HasExtraTime { get; set; }
        public bool HasPenalties { get; set; }
        public int HomeTeamGoalsInPenalties { get; set; }
        public int VisitorTeamGoalsInPenalties { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public Competition Competition { get; set; }
        public Team HomeTeam { get; set; }
        public Stage Stage { get; set; }
        public MatchType Type { get; set; }
        public Team VisitorTeam { get; set; }
        public ICollection<Bet> Bets { get; set; }

        #endregion
    }
}
