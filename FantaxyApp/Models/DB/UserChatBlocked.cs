using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class UserChatBlocked
    {
        public int ProfileBlocked { get; set; }
        public int? IdChat { get; set; }

        public virtual Chat? IdChatNavigation { get; set; }
        public virtual Profile ProfileBlockedNavigation { get; set; } = null!;
    }
}
