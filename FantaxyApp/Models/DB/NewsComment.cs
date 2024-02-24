using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class NewsComment
    {
        public int IdComment { get; set; }
        public int IdNews { get; set; }

        public virtual Comment IdCommentNavigation { get; set; } = null!;
        public virtual News IdNewsNavigation { get; set; } = null!;
    }
}
