using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class NewsInfo
    {
        public int IdNews { get; set; }
        public string Title { get; set; } = null!;
        public string? Desciption { get; set; }
        public byte[] MainAvatar { get; set; } = null!;
        public byte[]? Background { get; set; }
        public DateTime? DateNews { get; set; }

        public virtual News IdNewsNavigation { get; set; } = null!;
    }
}
