using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class User
    {
        public User()
        {
            UserForms = new HashSet<UserForm>();
        }

        public int UserId { get; set; }
        public string UserNick { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserSurname { get; set; } = null!;
        public string UserPassword { get; set; } = null!;

        public virtual ICollection<UserForm> UserForms { get; set; }
    }
}
