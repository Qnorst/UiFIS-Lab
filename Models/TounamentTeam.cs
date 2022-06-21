using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class TounamentTeam
    {
        public int TournamentId { get; set; }
        public int TeamId { get; set; }
        public int? WinnerTeamId { get; set; }
        public int TounamentTeamId { get; set; }
        public int TournamentStatusId { get; set; }

        public virtual Team Team { get; set; } = null!;
        public virtual Tounament Tournament { get; set; } = null!;
        public virtual TournamentStatus TournamentStatus { get; set; } = null!;
        public virtual Team? WinnerTeam { get; set; }
    }
}
