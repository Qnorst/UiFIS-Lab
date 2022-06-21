using System;
using System.Collections.Generic;

namespace TaskSearchWPF.Models
{
    public partial class Game
    {
        public Game()
        {
            UserForms = new HashSet<UserForm>();
        }

        public int GameId { get; set; }
        public string GameName { get; set; } = null!;

        public virtual ICollection<UserForm> UserForms { get; set; }
    }
}
