using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class TournamentStatus
    {
        public TournamentStatus()
        {
            TounamentTeams = new HashSet<TounamentTeam>();
        }

        public int TournamentStatusId { get; set; }
        public string TournamentStatusName { get; set; } = null!;

        public virtual ICollection<TounamentTeam> TounamentTeams { get; set; }
    }
}
