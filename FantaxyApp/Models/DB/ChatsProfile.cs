using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class ChatsProfile
    {
        public int IdCp { get; set; }
        public int IdChat { get; set; }

        public virtual Chat IdChatNavigation { get; set; } = null!;
    }
}
