using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class InTeamStatus
    {
        public InTeamStatus()
        {
            UserForms = new HashSet<UserForm>();
        }

        public int InTeamStatusId { get; set; }
        public string InTeamStatusName { get; set; } = null!;

        public virtual ICollection<UserForm> UserForms { get; set; }
    }
}
