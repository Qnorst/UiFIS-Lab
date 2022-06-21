using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSearchWPF.Models;

namespace TaskSearchWPF
{
    internal class Helper
    {
        public static TeamSearchContext db = new TeamSearchContext();
        public static User userSession;
    }
}
