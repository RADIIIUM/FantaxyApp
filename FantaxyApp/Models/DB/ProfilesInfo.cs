using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class ProfilesInfo
    {
        public int IdProfile { get; set; }
        public string ProfileName { get; set; } = null!;
        public string? ProfileDesc { get; set; }
        public byte[] Avatar { get; set; } = null!;
        public byte[]? MainBackground { get; set; }
        public byte[]? SecondBackground { get; set; }

        public virtual Profile IdProfileNavigation { get; set; } = null!;
    }
}
