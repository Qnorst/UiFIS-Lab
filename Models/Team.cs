using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class Team
    {
        public Team()
        {
            TounamentTeamTeams = new HashSet<TounamentTeam>();
            TounamentTeamWinnerTeams = new HashSet<TounamentTeam>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; } = null!;

        public virtual ICollection<TounamentTeam> TounamentTeamTeams { get; set; }
        public virtual ICollection<TounamentTeam> TounamentTeamWinnerTeams { get; set; }
    }
}
