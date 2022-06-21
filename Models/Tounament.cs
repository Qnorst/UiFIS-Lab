using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class Tounament
    {
        public Tounament()
        {
            TounamentTeams = new HashSet<TounamentTeam>();
        }

        public int TounamentId { get; set; }
        public string TournamentName { get; set; } = null!;

        public virtual ICollection<TounamentTeam> TounamentTeams { get; set; }
    }
}
