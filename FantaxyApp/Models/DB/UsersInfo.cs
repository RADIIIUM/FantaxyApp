using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class UsersInfo
    {
        public string UserLogin { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? UserDesc { get; set; }
        public byte[] Avatar { get; set; } = null!;
        public byte[]? MainBackground { get; set; }
        public byte[]? SecondBackground { get; set; }

        public virtual User UserLoginNavigation { get; set; } = null!;
    }
}
