using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class NewsStatus
    {
        public int IdNs { get; set; }
        public int? IdStatus { get; set; }
        public int IdNews { get; set; }

        public virtual News IdNewsNavigation { get; set; } = null!;
        public virtual Status? IdStatusNavigation { get; set; }
    }
}
