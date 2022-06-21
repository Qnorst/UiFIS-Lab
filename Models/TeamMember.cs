using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class TeamMember
    {
        public int UserId { get; set; }
        public int TeamId { get; set; }
        public int InTeamStatusId { get; set; }
        public int GameId { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual InTeamStatus InTeamStatus { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
