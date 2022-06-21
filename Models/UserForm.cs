using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class UserForm
    {
        public int UserFormId { get; set; }
        public string FormText { get; set; } = null!;
        public int PreferredInTeamStatusId { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual InTeamStatus PreferredInTeamStatus { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
