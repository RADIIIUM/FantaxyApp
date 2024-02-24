using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class UserProfile
    {
        public int IdProfile { get; set; }
        public string LoginUser { get; set; } = null!;

        public virtual Profile IdProfileNavigation { get; set; } = null!;
        public virtual User LoginUserNavigation { get; set; } = null!;
    }
}
