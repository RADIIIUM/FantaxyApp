using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB

{
    public partial class UserMessage
    {
        public int IdMessage { get; set; }
        public string MessageText { get; set; } = null!;
        public byte[]? MessageImage { get; set; }
        public int ProfileSender { get; set; }
        public int? IdChat { get; set; }

        public virtual Chat? IdChatNavigation { get; set; }
        public virtual Profile ProfileSenderNavigation { get; set; } = null!;
    }
}
