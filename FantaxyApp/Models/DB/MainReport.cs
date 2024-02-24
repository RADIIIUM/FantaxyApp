using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class MainReport
    {
        public int IdReport { get; set; }
        public string TextReport { get; set; } = null!;
        public string LoginUser { get; set; } = null!;

        public virtual User LoginUserNavigation { get; set; } = null!;
    }
}
