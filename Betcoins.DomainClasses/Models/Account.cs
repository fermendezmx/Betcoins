using System;
using System.Collections.Generic;

namespace Betcoins.DomainClasses.Models
{
    public class Account
    {
        public Account()
        {
            Competitions = new HashSet<AccountCompetition>();
            Bets = new HashSet<Bet>();
        }

        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public ICollection<AccountCompetition> Competitions { get; set; }
        public ICollection<Bet> Bets { get; set; }

        #endregion
    }
}
