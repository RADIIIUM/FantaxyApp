using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Profile
    {
        public Profile()
        {
            Chats = new HashSet<Chat>();
            Comments = new HashSet<Comment>();
            FriendIdProfile1Navigations = new HashSet<Friend>();
            FriendIdProfile2Navigations = new HashSet<Friend>();
            News = new HashSet<News>();
            PlanetProfileRoles = new HashSet<PlanetProfileRole>();
            PlanetProfiles = new HashSet<PlanetProfile>();
            PlanetReports = new HashSet<PlanetReport>();
            Posts = new HashSet<Post>();
            UserMessages = new HashSet<UserMessage>();
        }

        public int IdProfile { get; set; }
        public string UserLogin { get; set; } = null!;

        public virtual User UserLoginNavigation { get; set; } = null!;
        public virtual ProfilesInfo? ProfilesInfo { get; set; }
        public virtual UserChatBlocked? UserChatBlocked { get; set; }
        public virtual UserProfile? UserProfile { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Friend> FriendIdProfile1Navigations { get; set; }
        public virtual ICollection<Friend> FriendIdProfile2Navigations { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<PlanetProfileRole> PlanetProfileRoles { get; set; }
        public virtual ICollection<PlanetProfile> PlanetProfiles { get; set; }
        public virtual ICollection<PlanetReport> PlanetReports { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}
