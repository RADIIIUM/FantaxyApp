using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class ChatStatus
    {
        public int IdCs { get; set; }
        public int? IdStatus { get; set; }
        public int? IdChat { get; set; }

        public virtual Chat? IdChatNavigation { get; set; }
        public virtual Status? IdStatusNavigation { get; set; }
    }
}
