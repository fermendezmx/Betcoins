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

        public string AccountId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        #region Relationships

        public ICollection<AccountCompetition> Competitions { get; set; }
        public ICollection<Bet> Bets { get; set; }

        #endregion
    }
}
