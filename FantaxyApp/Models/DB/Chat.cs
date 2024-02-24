using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Chat
    {
        public Chat()
        {
            ChatStatuses = new HashSet<ChatStatus>();
            ChatsProfiles = new HashSet<ChatsProfile>();
            UserChatBlockeds = new HashSet<UserChatBlocked>();
            UserMessages = new HashSet<UserMessage>();
        }

        public int IdChat { get; set; }
        public int IdProfile { get; set; }

        public virtual Profile IdProfileNavigation { get; set; } = null!;
        public virtual PlanetChat? PlanetChat { get; set; }
        public virtual ICollection<ChatStatus> ChatStatuses { get; set; }
        public virtual ICollection<ChatsProfile> ChatsProfiles { get; set; }
        public virtual ICollection<UserChatBlocked> UserChatBlockeds { get; set; }
        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}
