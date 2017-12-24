using System;

namespace Betcoins.DomainClasses.Models
{
    public class TeamCompetitionGroup
    {
        public int TeamCompetitionGroupId { get; set; }
        public int TeamCompetitionId { get; set; }
        public int GroupId { get; set; }
        public int Points { get; set; }
        public int? Played { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Draw { get; set; }
        public int GoalFor { get; set; }
        public int GoalAgainst { get; set; }
        public int GoalDifference { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public Group Group { get; set; }
        public TeamCompetition TeamCompetition { get; set; }

        #endregion
    }
}
